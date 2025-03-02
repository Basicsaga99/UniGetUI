﻿using Microsoft.UI.Xaml.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniGetUI.Core.SettingsEngine;

namespace UniGetUI.Interface.Pages.LogPage
{
    public class OperationHistoryPage : BaseLogPage
    {
        public OperationHistoryPage() : base(false)
        {

        }

        public override void LoadLog()
        {
            Paragraph paragraph = new();
            foreach (string line in Settings.GetValue("OperationHistory").Split("\n"))
            {
                if (line.Replace("\r", "").Replace("\n", "").Trim() == "")
                {
                    continue;
                }

                paragraph.Inlines.Add(new Run { Text = line.Replace("\r", "").Replace("\n", "") });
                paragraph.Inlines.Add(new LineBreak());
            }
            LogTextBox.Blocks.Clear();
            LogTextBox.Blocks.Add(paragraph);

        }

        protected override void LoadLogLevels()
        {
            throw new NotImplementedException();
        }
    }
}
