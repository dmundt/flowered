﻿#region Header

// Copyright (c) 2009 Daniel Schubert
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion Header

namespace Flowered.App.SimpleClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Reflection;
    using System.Text;
    using System.Windows.Forms;

    public partial class FormAbout : Form
    {
        #region Constructors

        public FormAbout()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        ///
        /// </summary>
        private void FormAbout_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string runtime = System.Environment.Version.ToString();

            string copyright = rtbCredits.Text;
            copyright = copyright.Replace(@"{version}", version);
            copyright = copyright.Replace(@"{runtime}", runtime);
            rtbCredits.Text = copyright;
        }

        /// <summary>
        ///
        /// </summary>
        private void rtbCredits_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        #endregion Methods
    }
}