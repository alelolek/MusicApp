﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Presentation.View
{
	public partial class MusicPlayer : Form
	{
		WindowsMediaPlayer player = new WindowsMediaPlayer();
		public MusicPlayer()
		{
			InitializeComponent();
		}


	}
}
