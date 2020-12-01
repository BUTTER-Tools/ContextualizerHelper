using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;
using ContextObj;


namespace ContextualizerHelper
{
    public class ContextualizerHelper : Plugin
    {


        public string[] InputType { get; } = { "OutputArray" };
        public string OutputType { get; } = "Tokens";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { {0, "Tokens"} };
        public bool InheritHeader { get; } = false;


        #region Plugin Details and Info

        public string PluginName { get; } = "Helper: Contextualize Words";
        public string PluginType { get; } = "Preprocessing";
        public string PluginVersion { get; } = "1.0.0";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "Keeps only the contextualized words as tokens. Use the plugin settings to determine whether you want to keep the left and right context tokens, as well as the contextualized words themselves.";
        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "Coming Soon";


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion




        private bool KeepLeft { get; set; } = true;
        private bool KeepWords { get; set; } = true;
        private bool KeepRight { get; set; } = true;

        public void ChangeSettings()
        {


            using (var form = new SettingsForm_ContextualizerHelper(KeepLeft, KeepWords, KeepRight))
            {


                form.Icon = Properties.Resources.icon;
                form.Text = PluginName;


                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    KeepLeft = form.KeepLeft;
                    KeepRight = form.KeepRight;
                    KeepWords = form.KeepWords;
                }
            }



        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;

            ulong segments = 0;

            List<List<string>> tokens = new List<List<string>>();

            //figure out how many segments there are
            for (int i = 0; i < Input.SegmentNumber.Count; i++) if (Input.SegmentNumber[i] > segments)
                {
                    segments = Input.SegmentNumber[i];
                    tokens.Add(new List<string>());
                }



            for (int counter = 0; counter < Input.ObjectList.Count; counter++)
            {


                ContextObj.ContextObj context = (ContextObj.ContextObj)Input.ObjectList[counter];

                
                if (KeepLeft) for (int j = 0; j < context.LeftContext.Length; j++) tokens[((int)Input.SegmentNumber[counter]) - 1].Add(context.LeftContext[j]);
                if (KeepWords) for (int j = 0; j < context.MatchedWords.Length; j++) tokens[((int)Input.SegmentNumber[counter]) - 1].Add(context.MatchedWords[j]);
                if (KeepRight) for (int j = 0; j < context.RightContext.Length; j++) tokens[((int)Input.SegmentNumber[counter]) - 1].Add(context.RightContext[j]);

                

            }

            for (ulong counter = 0; counter < segments; counter++)
            {
                pData.StringArrayList.Add(tokens[(int)counter].ToArray());
                pData.SegmentNumber.Add(counter);
            }
            

            return (pData);



        }



        public void Initialize() { }


        public bool InspectSettings()
        {
            return true;
        }

        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }


        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {
            KeepLeft = Boolean.Parse(SettingsDict["KeepLeft"]);
            KeepRight = Boolean.Parse(SettingsDict["KeepRight"]);
            KeepWords = Boolean.Parse(SettingsDict["KeepWords"]);
        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            SettingsDict.Add("KeepLeft", KeepLeft.ToString());
            SettingsDict.Add("KeepRight", KeepRight.ToString());
            SettingsDict.Add("KeepWords", KeepWords.ToString());
            return (SettingsDict);
        }
        #endregion



    }
}
