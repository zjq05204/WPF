   M S B A M L   `   `   `  ����N  JmyWPFCustomControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:myWPFCustomControls;assembly=myWPFCustomControlsmyWPFCustomControls  5   	    	myThunder   myThunder.URLDownLoadWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   QmyWPFC>clr-namespace:myWPFCustomControls;assembly=myWPFCustomControls     5   	   -   5          � Title$  URLDownLoadWin��5   	   $	��300��6    $	��400��6-    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	   ��5   
   �� 5   
    �� ImageSource$+ %LocalResource/ThunderIcon/背景2.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��35 �6   �� 5      $��40 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��60 �6#   �� 5      $��1* �6#   �� 5      $��30 �6#   .+�5       �� $��1��6   $��新建任务��6$   
�������63   '   !myWPFCustomControls.myImageButton  5!      -   5          Name$ Quit_btn��5!   #   $��3��65   ��5"      �� 5#      $) #LocalResource/360Skin/Button/xn.png��6!      myMouseOverImage 5%      �� 5&      $) #LocalResource/360Skin/Button/xm.png��6!   	   myPressedImage	 5(      �� 5)      $) #LocalResource/360Skin/Button/xe.png��6!   5+      5,      �� 5.   
   
 �� Orientation$
 
Horizontal=�6   $��1��6.   .+�5/      �� $��下载链接��6   
�������$��Bottom=�66   �� 50      $#��(多个下载链接请换行)��6   ���sc# 1,0.8,0.2,0.2$��Bottom=�6I   51      � 53   
   $��2��6   .+�54      �� -   5         ��Name$ ctrl_download��54      $
��Auto=�61   $��5q�6a    �� 
IsReadOnly .  ��55      �� 56      .��57      �  � Color$ 	#00FFFFFF��6'   � 58      $ 	#A0FFFFFF��6'   59      5;      5=      �� 5?   
   $��3��6   $��下载完成后重命名��6   
�������$��Bottom=�6C   � 5@   
   $��4��6    5A      �� 5B      $��* �6#   �� 5C      $��80 �6#   .+�5E      �� -   5         ��Name$ ctrl_RenameFile��5E   &   $��0��6   $��3q�6?   
���   �.��6^   ��5F      �� 5G      .��5H      � $ 	#00FFFFFF��6'   � 5I      $ 	#90FFFFFF��6'   5J      .��5K   &   5L      �� 5M      -   5        $��1��5M      $��打开文件��6%   $��0,5,5,5q�64   6E   5N      �� 5O   
   -   5        $��5��5O      $��70��6   $��Right=�6)   $��开始下载��6E   $��8q�6T   6_   5Q      5R      