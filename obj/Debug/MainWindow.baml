   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WpfApplication1.ViewModelsWpfApplication1.ViewModels  5   	   S.clr-namespace:WpfApplication1.Views.Converters WpfApplication1.Views.Converters  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?
ViewModels(clr-namespace:WpfApplication1.ViewModels     5   	   E
Converters.clr-namespace:WpfApplication1.Views.Converters     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
Class List��5
   	   $	��500��6   $	��900��6)    � 	Resources 5      @   :WpfApplication1.Views.Converters.NullToVisibilityConverter   NullToVisibility  GridColumnHeight  GridColumnWidth  TextBoxHeight  TextBoxWidth  ButtonWidth  ButtonHeight,  &System.Windows.Controls.DataGridLength  DataGridColumnWidth5  /System.Windows.Controls.DataGridLengthConverter��%  &	        &	      &	 .     &	 I     &	 d     &	      &	 �     &	 �       5   
   6/   �5   
   500 �63   �5   
   300 �62   X�5   
   200Q�63   X�5   
   300Q�62   X�5   
   100Q�61   X�5   
   50Q�61    5   
   100 6:   5      .��5      �  � ColumnDefinitions 5   
   �� 5      #��[ 6   �� 5      #��[ 6   �� 5      #��[ 6   .+�5   
   �� $��0��6   .@�5      �� -   5        $��
InfoFields��5       � DataContext 5      1   +WpfApplication1.ViewModels.PersonCreationVM  5      .+�5!      �� .��6   First Name:6%   �� 5"      -   5        $��
First_name��5"   D    �� TextAlignment$ Center=�6V   $
��0,10q�6m   #��[ 6{   ��6   �� *	FirstName+ �� Mode$ Default=�6{   �� 5#      .��6   
Last Name:6$   �� 5$      -   5        $��	Last_name��5$   B   $ Center=�6S   $
��0,10q�6j   #��[ 6x   ��6   �� *
LastName+$ Default=�6x   �� 5%      .��6   Age:6   �� 5&      -   5        $	��Age��5&   =   $ Center=�6H   $
��0,10q�6_   #��[ 6m   ��6   �� *Age+$ Default=�6m   �� 5'      $
��Wrap=�5(      
���  ��$	��0 5q�5*      $��12(�5+      #��[ 5,       �� TextAlignment$ Center=�5-      ��5'      �� *Exception.Message+ �� StringFormat$ 
Error: {0}��y�5.      �� *	Exception+ �� 	Converter# [  50      �� 51      -   5        $��Submit��51      $��Submit��6�   $��100,10q�6�   $��Center=�6�   #��[ 6�   ��6#   �� *ClickSubmitCommand+��6J   �� 	 �� ElementName$	 
InfoFields��
 �� Path$
 DataContext�6�   52      &   System.Windows.Controls.DataGrid  54   
   -   5        $��	DataGrid1��54   Y   $��1��6      AutoGenerateColumns .     CanUserAddRows .  ��6j   �� *
Students+   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width# [ 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6f   �� *	FirstName+$ OneTime=� �� UpdateSourceTrigger$ PropertyChanged=�  58      $ 	Last Name��6%   # [ 68    6e   �� *
LastName+$ OneTime=�$ PropertyChanged=�  59      $	 Age��6%   # [ 62    6_   �� *Age+$ OneTime=�$ PropertyChanged=�5;      �� 5=   
   -   5        $��Delete��5=   !   $��2��6   $��Delete��6�   $��65,10q�6�   #��[ 6�   #��[ 6�   ��6/   �� *ClickDeleteCommand+��6V   �� $	 	DataGrid1��$
 SelectedItem�6�   5@      5B      