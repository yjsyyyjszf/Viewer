
#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Windows.Forms;

namespace Macro.Desktop.View.WinForms
{
    public partial class ApplicationManagerForm : Form
    {
        public ApplicationManagerForm()
        {
            InitializeComponent();
        }

        public void SetMiYao(string my)
        {
            this.Invoke(new Action(() => { miyao.Text = my; }));
        }

        public Button QuDing
        {
            get { return this.ok; }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetShouQuan
        {
            get { return richTextBox2.Text.Trim(); }
        }

    }
}