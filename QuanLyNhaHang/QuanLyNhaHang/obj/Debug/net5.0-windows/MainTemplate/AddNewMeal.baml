   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	       QuanLyNhaHang.AddNewMeal   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
AddNewMeal��5	   	   $	��400��6   $	��900��6)    � 
ResizeMode$ NoResize=�65    � WindowStartupLocation$ CenterScreen=�6K   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��76* �6   6-   �� 5      $
��149* �6   6.   .+�5   
   �� -   5         ��Name$ ChooseImageButton��5       #  MaterialDesignRaisedLightButton#��[  5      $��30��5      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5       � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��5      $��60,217,60,0q�5      $	��Top=�5      ���	#FFF38413.��5      �� $��Select Image��6   $
��Bold"�6,   $��10(�6>   
�������6L   5      � 5   
   -   5         �Name$ 	gridImage��5      $��0,50,0,0q�5      $	��150��5      $	��150��5      $��Center=�5      $	��Top=�5      .+�5      �� -   5         ��Name$ Image��5      $	��150��5       $	��150��5!      $
��Left=�5"      $	��Top=�5#      $
��Fill=�6'   5%      �� 5&      -   5        	 ��Name$	 recImage��5&      
 �� StrokeDashArray$	
 4 2R�5'      ���	#FFF38413$��4��5)       �� RadiusX$ 4��5*       �� RadiusY$ 4��5+      $	��150��5,      $	��150��5-      $
��Left=�5.      $	��Top=�5/      '  !MaterialDesignThemes.Wpf.PackIcon  51      -   5          Name$ 	Imageicon��51   &      Kind$ FileImageOutline=�69   ���	#FFF38413$��Center=�53   &   $��0,19,0,0q�6C   $��45��6U   $��50��6a   56      � 57   
   -   5        $ gridInfo��57      $��1��6!   $��0,50,0,0q�61    � RowDefinitions 58      �� 59      6"   �� 5:      6"   �� 5;      6"   �� 5<      6"    5>      �� 5?      6%   �� 5@      $��3* �6#   60   .+�5B      �� -   5         ��Name$ 
lbNameMeal��5C      $
��Name��6)   $��Right=�5D      $��Center=�6-   
���   �$��18(�5E   +   $
��Bold"�5F      $��0��6-   � 5G      -   5        $ grdNameMeal��5H      $��50,0,0,0q�5I      $��1��5J      .+�5K      �� -	   5        $	 recNameMeal��5K      $��40��5L      $	��300��63   $ 5��5M      $ 5��63   
�������$
��Left=�5N   1   �� 5O      -
   5         ��Name$ txtNameMeal��5P      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Meal's Name��5Q      $��14(�5T      $��0q�6)    �� MaxLines$ 1��5U      $
��Left=�5V      $
��Left=�69   $��Center=�5W      $��Center=�69   $
��Bold"�5X      ��5R      �� *ActualWidth+ �� ElementName$ recNameMeal����5S      �� *ActualHeight+$ recNameMeal�� �� SelectionBrush 5U   )   Z� 5X      5Y      �� 5Z      -   5        $ 
lbCategory��5[      $��Category��6)   $��1��6A   ��5\      �� *HorizontalAlignment+$ 
lbNameMeal����5]      �� *VerticalAlignment+$ 
lbNameMeal����5^      �� *
Foreground+$ 
lbNameMeal����5_      �� *
FontSize+$ 
lbNameMeal����5`      �� *
FontWeight+$ 
lbNameMeal��� 5a      -   5        $ grdCategory��5b      $��1��5c      $��1��6)   ��5b   )   �� *Margin+$ grdNameMeal��.+�5d      �� -   5        $	 recCategory��5d      ��5e      �� *ActualHeight+$ recNameMeal����5f      �� *ActualWidth+$ recNameMeal�� 5g      �� *	RadiusX+$ recNameMeal�� 5h      �� *	RadiusY+$ recNameMeal����5i      �� *Stroke+$ recNameMeal����5j      �� *Margin+$ recNameMeal����5k      �� *HorizontalAlignment+$ recNameMeal���� 5l      -   5        $��cmbCategory��5m      $ Meal's category��5n       �� 
IsEditable$ False��5q      ��5o      �� *HorizontalAlignment+$ txtNameMeal����5p      �� *
FontWeight+$ txtNameMeal����5r      �� *ActualWidth+$ recNameMeal����5s      �� *ActualHeight+$ recNameMeal����5t      �� *#!LongListToTestComboVirtualization+ �� Text 5u      �� 5v       �� Path$ SelectedTextTwo�5w       �� Mode$ TwoWay=�5x       �� UpdateSourceTrigger$ PropertyChanged=�5y      5z      ��5|      �� 5}      .R�5~      $� 5      5�      5�      �� 5�      -   5        $ lbPriceMeal��5�      $��Price��6)   $��2��6=   ��5�      �� *HorizontalAlignment+$ 
lbNameMeal����5�      �� *VerticalAlignment+$ 
lbNameMeal����5�      �� *
Foreground+$ 
lbNameMeal����5�      �� *
FontSize+$ 
lbNameMeal����5�      �� *
FontWeight+$ 
lbNameMeal��� 5�      -   5        $ grdPriceMeal��5�      $��1��6)   $��2��6=   ��5�      �� *Margin+$ grdNameMeal��.+�5�      �� -   5        $	 recPriceMeal��5�      ��5�      �� *ActualHeight+$ recNameMeal����5�      �� *ActualWidth+$ recNameMeal�� 5�      �� *	RadiusX+$ recNameMeal�� 5�      �� *	RadiusY+$ recNameMeal����5�      �� *Stroke+$ recNameMeal����5�      �� *HorizontalAlignment+$ recNameMeal���� 5�      -   5        $ txtPriceMeal��5�      $ Meal's price��5�      ��5�      �� *ActualWidth+$ txtNameMeal����5�      �� *ActualHeight+$ txtNameMeal����5�      �� *
FontSize+$ txtNameMeal����5�      �� *BorderThickness+$ txtNameMeal�� 5�      �� *
MaxLines+$ txtNameMeal�� 5�      Z� ��5�      �� *HorizontalContentAlignment+$ txtNameMeal����5�      �� *HorizontalAlignment+$ txtNameMeal����5�      �� *VerticalContentAlignment+$ txtNameMeal����5�      �� *VerticalAlignment+$ txtNameMeal����5�      �� *
FontWeight+$ txtNameMeal��5�      � 5�      -   5        $ grdSelection��5�      $��Center=�5�      $
��Left=�6.   $��6��5�      $��1��6    ��5�      �� *ActualWidth+$ recNameMeal����5�      �� *Margin+$ grdNameMeal�� 5�      �� 5�      6)   �� 5�      6)   �� 5�      6)   .+�5�      �� -   5        $ 
btnConfirm��5�      $��0��6-   ���	#FFF38413$��Confirm��5�   0   
�������$��11(�5�   ,   $
��Bold"�6:    ! MaterialDesignFlatMidBgButton#��[ 5�      $ 10��5�      6G   �� 5�      -   5        $ 	btnCancel��5�      $��2��6,   $��Cancel��5�   S   $��11(�5�   S      MaterialDesignOutlinedButton#��[ 5�      $ 10��5�      ��5�      �� *
Foreground+$ 
btnConfirm����5�      �� *
Background+$ 
btnConfirm����5�      �� *
FontWeight+$ 
btnConfirm��5�   G   5�      5�      5�      5�      