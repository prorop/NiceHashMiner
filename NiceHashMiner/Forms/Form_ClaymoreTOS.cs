﻿using NiceHashMiner.Configs;
using NiceHashMiner.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiceHashMiner.Forms {
    public partial class Form_ClaymoreTOS : Form {
        public Form_ClaymoreTOS() {
            InitializeComponent();

            this.Text = International.GetText("Form_Main_3rdParty_Title");
            this.label_Tos.Text = International.GetText("Form_Main_3rdParty_Text");
            this.button_Agree.Text = International.GetText("Form_Main_3rdParty_Button_Agree_Text");
            this.button_Decline.Text = International.GetText("Form_Main_3rdParty_Button_Refuse_Text");
        }

        private void button_Agree_Click(object sender, EventArgs e) {
            ConfigManager.Instance.GeneralConfig.Use3rdPartyMiners = Use3rdPartyMiners.YES;
            this.Close();
        }

        private void button_Decline_Click(object sender, EventArgs e) {
            ConfigManager.Instance.GeneralConfig.Use3rdPartyMiners = Use3rdPartyMiners.NO;
            this.Close();
        }
    }
}
