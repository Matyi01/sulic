   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      
 kreta2!   KretaClone.Views.JegyekPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      6sys&clr-namespace:System;assembly=mscorlib     5        N� Title$  Jegyek��5      .��5      �� $��20q�6   
�������.+�5   
   �� $��Új jegy hozzáadása��6   $
��Bold"�6.   $��18(�6@   $��0,0,0,10q�6N   �� 5
   
    �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� -   5         ��Name$ TantargyTextBox��5      $	��120��6/   $��0,0,10,0q�6;   �� 5      -   5        $ JegyTextBox��5      $��50��6+   $��0,0,10,0q�66   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatumPicker��5      
 �� Now   SelectedDate# Z 6.   $	��140��6Y   $��0,0,10,0q�6e   �� 5      -   5        $��Hozzáadás��5      6)   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ JegyekDataGrid��5         AutoGenerateColumns$ False��6+      CanUserAddRows$ False��6G   $	��300��6^   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Tantárgy��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *
Tantargy+6T     5      $

 Jegy��6%   $ * 6Q    63   �� *	JegyErtek+6Q     5      $
 Dátum��6%   $ * 6N    64   �� *Datum+6N   5      5      5      