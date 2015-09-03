using System;
using System.Windows;
using System.Windows.Controls;
namespace myWPFCustomControls
{
	public class DazzleTabControl : TabControl
	{
        static DazzleTabControl()
		{
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(DazzleTabControl), new FrameworkPropertyMetadata(typeof(DazzleTabControl)));
		}
	}
}
