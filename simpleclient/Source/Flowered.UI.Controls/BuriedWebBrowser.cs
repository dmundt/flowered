﻿// Copyright ©2009 Daniel Schubert
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

namespace Flowered.UI.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Text;
    using System.Windows.Forms;

    #region Delegates

    public delegate void PreviewKeyDownHandler(object sender, PreviewKeyDownEventArgs e);

    #endregion Delegates

    public partial class BuriedWebBrowser : UserControl
    {
        #region Constructors

        public BuriedWebBrowser()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Events

        public new event PreviewKeyDownHandler PreviewKeyDown;

        #endregion Events

        #region Properties

        public bool Buried
        {
            get
            {
                return transparentPanel.Enabled;
            }
            set
            {
                transparentPanel.Enabled = value;
            }
        }

        public Uri Url
        {
            get
            {
                return webBrowser.Url;
            }
            set
            {
                webBrowser.Url = value;
            }
        }

        #endregion Properties

        #region Methods

        public void Navigate(Uri url)
        {
            webBrowser.Navigate(url);
        }

        public void Refresh(WebBrowserRefreshOption opt)
        {
            webBrowser.Refresh(opt);
        }

        public void Snapshot(string filename, ImageFormat imageFormat)
        {
            // grab and save snapshot
            using (Bitmap bitmap = new Bitmap(webBrowser.ClientSize.Width,
                webBrowser.ClientSize.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(webBrowser.Parent.PointToScreen(webBrowser.Location),
                        new Point(0, 0), webBrowser.ClientSize, CopyPixelOperation.SourceCopy);
                    bitmap.Save(filename, imageFormat);
                }
            }
        }

        protected new void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            if (PreviewKeyDown != null)
            {
                // Invokes the delegates.
                PreviewKeyDown(this, e);
            }
        }

        private void webBrowser_DocumentCompleted(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            Focus();
        }

        private void webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            OnPreviewKeyDown(e);
        }

        #endregion Methods
    }
}