   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyNhaHang.MainTemplateQuanLyNhaHang.MainTemplate  5      *    $QuanLyNhaHang.MainTemplate.EditTable   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:QuanLyNhaHang.MainTemplate     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  	EditTable��5	      $	��750��5
      $	��250��5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   .+�5   
   � -   5         �Name$ restaurantInformation��5      $��Center=�6.   .+�5      �� $"��/MainTemplate/restaurant.png��6   5      � 5   
   -   5        $ gridInfo��5      $��1��5      $��0,50,0,0q�5       � RowDefinitions 5      �� 5      �� 5       5      �� 5      �� 5      $��3* �6#   .+�5!      �� -   5         ��Name$ lbTable��5"      $��0��5#      $��Right=�5$      $��Center=�5%      $��Table��5&      $��18(�5'      $
��Bold"�5(      
���   �5)      � 5*      -   5        $ grdTable��5+      $��1��5,      $��50,0,0,0q�5-      .+�5.      �� -   5         ��Name$ recNameTable��5/      $	��300��50      $��40��51      $
��Left=�52       �� RadiusX$ 5��53       �� RadiusY$ 5��54      
�������55      �� 56      -   5         ��Name$ txtTable��57      $
��Left=�5:      $��Center=�5;      $
��Left=�5<      $��Center=�5=      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Table's new name��5>      $��0q�5?      $��14(�5@      $
��Bold"�5A      
 �� MaxLines$
 1��5B      ��58      �� *ActualWidth+ �� ElementName$ recNameTable����59      �� *ActualHeight+$ recNameTable�� �� SelectionBrush 5C      Z� 5D      � 5E      -   5        $ grdSelection��5F      $��6��5G      $��1��5H      $
��Left=�5K      $��Center=�5L      ��5I      �� *ActualWidth+$ recNameTable����5J      �� *Margin+$ grdTable�� 5M      �� 5N      �� 5O      �� 5P      .+�5R      �� -   5         ��Name$ 
btnConfirm��5S      $��0��5T      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5U      ���	#FFF38413$��Confirm��5X      $��11(�5Y      $
��Bold"�5Z      
������� !  MaterialDesignFlatMidBgButton#��[  5\      �� 5^      -	   5        $ 	btnCancel��5_      $��2��5`      $ 10��5a      $��Cancel��5d      $��11(�5e         MaterialDesignOutlinedButton#��[ 5h      ��5b      �� *
Foreground+$ 
btnConfirm����5f      �� *
FontWeight+$ 
btnConfirm����5g      �� *
Background+$ 
btnConfirm��5h      5i      5j      5k      5l      