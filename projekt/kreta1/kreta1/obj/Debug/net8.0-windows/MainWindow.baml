   M S B A M L   `   `   `  ����A  =kreta1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kreta1kreta1  5   	       kreta1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:kreta1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
tabControl��5
      .@�5      �� -   5         ��Name$ fooldal��5      $��Főoldal��6'   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $
��251* �6+   �� 5      $
��543* �6+   5      5      �� 5      -   5        $ orarend��5      $��Óraend��6'   .��5      � ���	#FFE5E5E56   5      �� 5      -   5        $ ertesitesek��5      $��Értesítések��6+   .��5      � ���	#FFE5E5E56   5      �� 5      -   5        $ 	mulasztas��5      $��
Mulasztás��6)   .��5      � ���	#FFE5E5E5.+�5      �� $��Mulasztott órák:��6   $
��Left=�67   $��	10,10,0,0q�6R   $	��Top=�6e   �� 5      $
��Left=�6    $��
110,15,0,0q�6;   $
��Wrap=�6O   $��0��6c   $	��Top=�6l   �� 5      $��Igazolt órák:��6   $
��Left=�64   $��	10,41,0,0q�6O   $	��Top=�6b   �� 5      $
��Left=�6    $��	90,46,0,0q�6;   $
��Wrap=�6N   $��0��6b   $	��Top=�6k   �� 5       $��10,72,10,10q�6I   5#      5$      5%      �� 5&      -   5        $ egyeb��5&      $��Egyéb��6%   .��5'      � ���	#FFE5E5E56   5(      5)      5+      5,      