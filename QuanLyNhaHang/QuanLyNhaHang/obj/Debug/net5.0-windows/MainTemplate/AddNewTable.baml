   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:QuanLyNhaHang.MainTemplateQuanLyNhaHang.MainTemplate  5   	   ,    &QuanLyNhaHang.MainTemplate.AddNewTable   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:QuanLyNhaHang.MainTemplate     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  AddNewTable��5	   	   $	��300��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      $��2* �6   6,   .+�5   
   � -   5         �Name$ 	gridImage��5      $��0,50,0,0q�5      $	��150��5      $	��150��5      $��Center=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ recImage��5       �� StrokeDashArray$	 4 2R�5      ���	#FFF38413$��4��5       �� RadiusX$ 4��5       �� RadiusY$ 4��5      $	��150��5      $	��150��5      $
��Left=�5      $	��Top=�5      �� 5       #  MaterialDesignRaisedLightButton#��[  5       $��30��5!      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5"      	 � ToolTip$8	 2MaterialDesignRaisedLightButton with Round Corners��5#      $��
30,94,30,0q�5$      $	��Top=�5%      ���	#FFF38413.��5&      �� $��Select Image��6   $
��Bold"�60   $��10(�6B   
�������6P   5'      '  !MaterialDesignThemes.Wpf.PackIcon  5(      
   Kind$
 FileImageOutline=�6&   ���	#FFF38413$��Center=�5*   &   $��0,19,0,0q�6C   $��45��6U   $��50��6a   5-      � 5.   
   -   5        $ gridInfo��5.      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 5/      �� 50      6"   �� 51      6"   �� 52      6"   �� 53      6"    55      �� 56      6%   �� 57      $��3* �6#   60   .+�59      �� -   5         ��Name$ 
lbNameMeal��5:      $
��Name��6)   $��Right=�5;      $��Center=�6-   
���   �$��18(�5<   +   $
��Bold"�5=      $��0��6-   � 5>      -   5        $ grdNameMeal��5?      $��50,0,0,0q�5@      $��1��5A      .+�5B      �� -   5        $ recNameMeal��5B      $��40��5C      $	��300��63   $ 5��5D      $ 5��63   
�������$
��Left=�5E   1   �� 5F      -   5         ��Name$ txtNameTable��5G      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Table's Name��5H      $��14(�5K      $��0q�6)    �� MaxLines$ 1��5L      $
��Left=�5M      $
��Left=�69   $��Center=�5N      $��Center=�69   $
��Bold"�5O      ��5I      �� *ActualWidth+ �� ElementName$ recNameMeal����5J      �� *ActualHeight+$ recNameMeal�� �� SelectionBrush 5L   )   Z� 5O      5P      �� 5Q      -   5        $ 
lbCategory��5R      $��ID��6)   $��1��6;   ��5S      �� *HorizontalAlignment+$ 
lbNameMeal����5T      �� *VerticalAlignment+$ 
lbNameMeal����5U      �� *
Foreground+$ 
lbNameMeal����5V      �� *
FontSize+$ 
lbNameMeal����5W      �� *
FontWeight+$ 
lbNameMeal��� 5X      -	   5        $ grdCategory1��5Y      $��1��5Z      $��1��6)   ��5Y   *   �� *Margin+$ grdNameMeal��.+�5[      �� -
   5        $ recCategory��5[      ��5\      �� *ActualHeight+$ recNameMeal����5]      �� *ActualWidth+$ recNameMeal�� 5^      �� *	RadiusX+$ recNameMeal�� 5_      �� *	RadiusY+$ recNameMeal����5`      �� *Stroke+$ recNameMeal����5a      �� *Margin+$ recNameMeal����5b      �� *HorizontalAlignment+$ recNameMeal���� 5c      -   5        $ 
txtTableID��5d      $ 
Table's ID��5e      $
��Bold"�5n      $��	0,10,0,10q�6'   ��5f      �� *ActualWidth+$ txtNameMeal����5g      �� *ActualHeight+$ txtNameMeal����5h      �� *
FontSize+$ txtNameMeal����5i      �� *BorderThickness+$ txtNameMeal�� 5j      �� *
MaxLines+$ txtNameMeal�� 5k      Z� ��5l      �� *HorizontalContentAlignment+$ txtNameMeal����5m      �� *VerticalContentAlignment+$ txtNameMeal��5n   '   5p      �� 5q      -   5        $ lbPriceMeal��5r      $��Status��6)   $��2��6>   ��5s      �� *HorizontalAlignment+$ 
lbNameMeal����5t      �� *VerticalAlignment+$ 
lbNameMeal����5u      �� *
Foreground+$ 
lbNameMeal����5v      �� *
FontSize+$ 
lbNameMeal����5w      �� *
FontWeight+$ 
lbNameMeal��� 5x      -   5        $ grdPriceMeal��5y      $��1��6)   $��2��6=   ��5z      �� *Margin+$ grdNameMeal��.+�5{      �� -   5        $ recPriceMeal��5{      ��5|      �� *ActualHeight+$ recNameMeal����5}      �� *ActualWidth+$ recNameMeal�� 5~      �� *	RadiusX+$ recNameMeal�� 5      �� *	RadiusY+$ recNameMeal����5�      �� *Stroke+$ recNameMeal����5�      �� *HorizontalAlignment+$ recNameMeal���� 5�      -   5        $ txtTableStatus��5�      $ Table's status��5�      $��	0,10,0,10q�5�   P   ��5�      �� *ActualWidth+$ txtNameMeal����5�      �� *ActualHeight+$ txtNameMeal����5�      �� *
FontSize+$ txtNameMeal����5�      �� *BorderThickness+$ txtNameMeal�� 5�      �� *
MaxLines+$ txtNameMeal�� 5�      Z� ��5�      �� *HorizontalContentAlignment+$ txtNameMeal����5�      �� *VerticalContentAlignment+$ txtNameMeal����5�      �� *
FontWeight+$ txtNameMeal��6P   5�      � 5�      -   5        $ grdSelection��5�      $��Center=�5�      $
��Left=�6.   $��6��5�      $��1��6    ��5�      �� *ActualWidth+$ recNameMeal����5�      �� *Margin+$ grdNameMeal�� 5�      �� 5�      6)   �� 5�      6)   �� 5�      6)   .+�5�      �� -   5         ��Name$ 
btnConfirm��5�      $��0��6-   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    ! MaterialDesignFlatMidBgButton#��[ 5�      $ 10��5�      6G   �� 5�      -   5        $ 	btnCancel��5�      $��2��6,   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $ 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�   G   5�      5�      5�      5�      