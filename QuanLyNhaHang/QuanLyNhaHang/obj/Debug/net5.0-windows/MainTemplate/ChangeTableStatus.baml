   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	   %    QuanLyNhaHang.ChangeTableStatus   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ChangeTableStatus��5	   	   $	��328��6#   $	��808��60   .��5
      � $��0,0,0,-6q�6   .+�5   
   � -   5         �Name$ 	gridImage��5      $��	50,50,0,0q�5      $	��150��5      $	��150��5      $
��Left=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ recImage��5       �� StrokeDashArray$	 4 2R�5      ���	#FFF38413$��4��5       �� RadiusX$ 4��5       �� RadiusY$ 4��5      $	��150��5      $	��150��5      $
��Left=�5      $	��Top=�5      �� 5       #  MaterialDesignRaisedLightButton#��[  5      $��30��5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5        � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��5!      $��
30,94,30,0q�6J   $	��Top=�5"      ���	#FFF38413.��5$      �� $��Select Image��6   $
��Bold"�60   $��10(�6B   
�������6P   5%      '  !MaterialDesignThemes.Wpf.PackIcon  5&         Kind$ FileImageOutline=�6&   ���	#FFF38413$��Center=�5(   &   $��0,19,0,0q�6C   $��45��6U   $��50��6a   5+      � 5,   
   -   5        $ gridInfo��5,      $��400,20,0,118q�6!   .+�5-      � -   5        $ grdIDEmployee��5.      $��	0,0,-20,0q�5/      $	��Top=�50      $	��420��51      $��40��52      .+�53      �� -   5        	 ��Name$	 	lbIDTable��54      $��ID��55      $
��Left=�56      $	��Top=�57      
���   �$��18(�59      $
��Bold"�5:      $��0,8,0,0q�6'   �� 5;      -   5        $ 
recIDTable��5;      $��40��5<      $	��290��5=      $ 6��5>      $ 6��5?      $��90,0,0,0q�6(   
�������$
��Left=�5A      �� 5B      -   5        
 ��Name$
 
txtIDTable��5C      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Table's ID��5D      $
��Left=�5E      $	��266��5F      $��14(�5G      $��0q�5H       �� MaxLines$ 1��5I      $��0q�5J      $��40��5K      $
��Left=�5L      $��Center=�5M      $��Center=�5N      $
��Bold"�5P      $��	102,0,0,0q�6'    �� SelectionBrush 5O      Z� 5P   '   5Q      � 5R      -   5        $ grdTableStatus��5S      $��
0,60,-20,0q�5T      $	��Top=�5U      $	��420��5V      $��40��5W      .+�5X      �� -	   5        $	 lbTableStatus��5Y      $��Status��5Z      $
��Left=�5[      $��Center=�5\      
���   �$��18(�5^      $
��Bold"�5_      �� 5`      -
   5        $ recTableStatus��5`      $��40��5a      $	��290��5b      $ 6��5c      $ 6��5d      $��90,0,0,0q�6(   
�������$
��Left=�5f      �� 5g      $
��Bold"�5h      $ Table status��5i      $��72��5j      $��
100,0,50,0q�5l   .   ��5k      �� *#!LongListToTestComboVirtualization+ �� SelectedValue 5l      �� *SelectedValueOne+.@�5m      �� $��	Available��6#   $
��Bold"�67   
��� � �6I   �� 5n      $
��Busy��6#   $
��Bold"�62   
���  ��6D   �� 5o      $��Reserved��6#   $
��Bold"�66   
��� ���6H   5q      5s      5t      � 5u   
   -   5        $ grdSelection��5u      $	��220��6%   $��40��61   $��Bottom=�6=   $��Right=�6X   $��	0,0,73,64q�6t    � ColumnDefinitions 5v      �� 5w      6%   �� 5x      6%   �� 5y      6%   .+�5{      �� -   5         ��Name$ 
btnConfirm��5{      $��0��6)   ���	#FFF38413$��Confirm��6P   
�������$��11(�6u   $
��Bold"�6�    ! MaterialDesignFlatMidBgButton#��[ 6�   $ 10��6�   �� 5}      -   5        $ 	btnCancel��5}      $��2��6(   
�������$��Cancel��6K   ���	#FFF38413$��11(�6s   $
��Bold"�6�      MaterialDesignOutlinedButton#��[ 6�   $ 10��6�   5~      5      5�      