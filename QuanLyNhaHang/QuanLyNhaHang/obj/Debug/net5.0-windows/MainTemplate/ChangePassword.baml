   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	   "    QuanLyNhaHang.ChangePassword   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  ChangePassword��5	   	   $	��400��6    $	��900��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ 	gridImage��5      $��0,50,0,0q�5      $	��150��5      $	��150��5      $��Center=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ recImage��5       �� StrokeDashArray$	 4 2R�5      ���	#FFF38413$��4��5       �� RadiusX$ 4��5       �� RadiusY$ 4��5      $	��150��5      $	��150��5      $
��Left=�5      $	��Top=�5      �� 5       #  MaterialDesignRaisedLightButton#��[  5       $��30��5!      +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 5��5"      
 � ToolTip$8
 2MaterialDesignRaisedLightButton with Round Corners��5#      $��
30,94,30,0q�5$      $	��Top=�5%      ���	#FFF38413.��5&      �� $��Select Image��6   $
��Bold"�60   $��10(�6B   
�������6P   5'      '  !MaterialDesignThemes.Wpf.PackIcon  5(         Kind$ FileImageOutline=�6&   ���	#FFF38413$��Center=�5*   &   $��0,19,0,0q�6C   $��45��6U   $��50��6a   5-      � 5.   
   -   5        $ gridInfo��5.      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5/      �� 50      6"   �� 51      6"   �� 52      6"   �� 53      6"    55      �� 56      6%   �� 57      $��3* �6#   60   .+�59      �� -   5         ��Name$ lbUserNameEmployee��5:      $��UserName��61   $��Right=�5;      $��Center=�6-   
���   �$��18(�5<   +   $
��Bold"�5=      $��0��6-   � 5>      -   5        $ grdUserNameEmployee��5?      $��50,0,0,0q�5@      $��1��5A      .+�5B      �� -   5        $ recUserNameEmployee��5B      $��40��5C      $	��300��63   $ 5��5D      $ 5��63   
�������$
��Left=�5E   1   �� 5F      -   5         ��Name$ txtUserNameEmployee��5G       �� 
IsReadOnly$
 True��5H      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee's UserName��5I      $��14(�5L      $��0q�6)    �� MaxLines$ 1��5M      $
��Left=�5N      $
��Left=�69   $��Center=�5O      $��Center=�69   $
��Bold"�5P      ��5J      �� *ActualWidth+ �� ElementName$ recNameEmployee����5K      �� *ActualHeight+$ recUserNameEmployee�� �� SelectionBrush 5M   )   Z� 5P      5Q      �� 5R      -   5        $ lbPasswordEmployee��5S      $��Password��60   $��1��6G   ��5T      �� *HorizontalAlignment+$ lbUserNameEmployee����5U      �� *VerticalAlignment+$ lbUserNameEmployee����5V      �� *
Foreground+$ lbUserNameEmployee����5W      �� *
FontSize+$ lbUserNameEmployee����5X      �� *
FontWeight+$ lbUserNameEmployee��� 5Y      -	   5        $ grdPasswordEmployee��5Z      $��1��60   $��1��6D   ��5[      �� *Margin+$ grdUserNameEmployee��.+�5\      �� -
   5        $ recPasswordEmployee��5\      ��5]      �� *ActualHeight+$ recUserNameEmployee����5^      �� *ActualWidth+$ recUserNameEmployee�� 5_      �� *	RadiusX+$ recUserNameEmployee�� 5`      �� *	RadiusY+$ recUserNameEmployee����5a      �� *Stroke+$ recUserNameEmployee����5b      �� *HorizontalAlignment+$ recUserNameEmployee��G� 5c      -   5         G�Name$ txtPasswordEmployee��5d      $ Employee's password��5e      ��5f      �� *ActualWidth+$ txtUserNameEmployee����5g      �� *ActualHeight+$ txtUserNameEmployee����5h      �� *
FontSize+$ txtUserNameEmployee����5i      �� *BorderThickness+$ txtUserNameEmployee�� G� SelectionBrush 5j      Z� ��5k      �� *HorizontalContentAlignment+$ txtUserNameEmployee����5l      �� *HorizontalAlignment+$ txtUserNameEmployee����5m      �� *VerticalContentAlignment+$ txtUserNameEmployee����5n      �� *VerticalAlignment+$ txtUserNameEmployee����5o      �� *
FontWeight+$ txtUserNameEmployee��5p      �� 5q      -   5        $ lbConfirmPassword��5r      $��Confirm��62   $��2��6K   ��5s      �� *HorizontalAlignment+$ lbUserNameEmployee����5t      �� *VerticalAlignment+$ lbUserNameEmployee����5u      �� *
Foreground+$ lbUserNameEmployee����5v      �� *
FontSize+$ lbUserNameEmployee����5w      �� *
FontWeight+$ lbUserNameEmployee��� 5x      -   5        $ grdConfirmPassword��5y      $��1��62   $��2��6F   ��5z      �� *Margin+$ grdUserNameEmployee��.+�5|      �� -   5        $ recConfirmPassword��5|      ��5}      �� *ActualHeight+$ recUserNameEmployee����5~      �� *ActualWidth+$ recUserNameEmployee�� 5      �� *	RadiusX+$ recUserNameEmployee�� 5�      �� *	RadiusY+$ recUserNameEmployee����5�      �� *Stroke+$ recUserNameEmployee����5�      �� *HorizontalAlignment+$ recUserNameEmployee��G� 5�      -   5        $ txtConfirmPassword��5�      $ Confirm password��5�      ��5�      �� *ActualWidth+$ txtUserNameEmployee����5�      �� *ActualHeight+$ txtUserNameEmployee����5�      �� *
FontSize+$ txtUserNameEmployee����5�      �� *BorderThickness+$ txtUserNameEmployee�� 5�      Z� ��5�      �� *HorizontalContentAlignment+$ txtUserNameEmployee����5�      �� *HorizontalAlignment+$ txtUserNameEmployee����5�      �� *VerticalContentAlignment+$ txtUserNameEmployee����5�      �� *VerticalAlignment+$ txtUserNameEmployee����5�      �� *
FontWeight+$ txtUserNameEmployee��5�      � 5�      -   5        $ grdSelection��5�      $��Center=�5�      $
��Left=�6.   $��7��5�      $��1��6    ��5�      �� *ActualWidth+$ recUserNameEmployee����5�      �� *Margin+$ grdUserNameEmployee�� 5�      �� 5�      6)   �� 5�      6)   �� 5�      6)   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��6-   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    ! MaterialDesignFlatMidBgButton#��[ 5�      $	 10��5�      �� 5�      -   5        $ 	btnCancel��5�      $��2��6,   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $	 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�      5�      5�      5�      5�      