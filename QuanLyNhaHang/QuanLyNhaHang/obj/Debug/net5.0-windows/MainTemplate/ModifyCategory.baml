   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	   "    QuanLyNhaHang.ModifyCategory   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Modify Category��5	   	   $	��300��6!   $	��800��6.    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5      �� 5      6"   �� 5      6"    5      �� 5      6%   �� 5      $��3* �6#   60   .+�5      �� -   5         ��Name$ 
lbCatecory��5      $
��Name��6)   $��Right=�5      $��Center=�6-   
���   �$��18(�5   +   $
��Bold"�5      $��0��6-   � 5       -   5        $ grdNameCategory��5!      $��50,0,0,0q�5"      $��1��5#      .+�5$      �� -   5         ��Name$ recNameCategory��5$      $��40��5%      $	��300��63    �� RadiusX$ 5��5&      	 �� RadiusY$	 5��63   
�������$
��Left=�5'   1   �� 5(      -   5        
 ��Name$
 txtNameCategory��5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Category's Name��5*      $��14(�5-      $��0q�6)    �� MaxLines$ 1��5.      $
��Left=�5/      $
��Left=�69   $��Center=�50      $��Center=�69   $
��Bold"�51      ��5+      �� *ActualWidth+ �� ElementName$ recNameCategory����5,      �� *ActualHeight+$ recNameCategory�� �� SelectionBrush 5.   )   Z� 51      52      � 53      -   5        $ grdSelection��53      $��Center=�56      $
��Left=�6.   $��6��57      $��1��6    ��54      �� *ActualWidth+$ recNameCategory����55      �� *Margin+$ grdNameCategory�� 58      �� 59      6)   �� 5:      6)   �� 5;      6)   .+�5=      �� -   5         ��Name$ 
btnConfirm��5=      $��0��6-   ���	#FFF38413$��Confirm��5>   0   
�������$��11(�5?   ,   $
��Bold"�6:    !  MaterialDesignFlatMidBgButton#��[  5@      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5A      5B      �� 5D      -	   5        $ 	btnCancel��5D      $��2��6,   $��Cancel��5E   S   $��11(�5F   S      MaterialDesignOutlinedButton#��[ 5H      $ 10��5I      ��5E      �� *
Foreground+$ 
btnConfirm����5F      �� *
Background+$ 
btnConfirm����5G      �� *
FontWeight+$ 
btnConfirm��5J      5K      5L      5M      5N      