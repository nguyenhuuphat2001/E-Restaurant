   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5          QuanLyNhaHang.MainMenu   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyNhaHang     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      $
��1083��5
      $	��733��5        � 
ResizeMode$  NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5         MenuOpen �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%�  &	        &	 �     �� 5   
   .��5      U� $ GridMenu��6,   $ (FrameworkElement.Width)�6M   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ GridMenu��6,   $ (FrameworkElement.Width)�6M   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      5      5       � Triggers 5      :� 5    
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5!      �� #��[  6   5"      :� 5#   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5$      �� #��[ 6   5%      .��5'      � .+�5)   
   � -   5         �Name$ GridMain��5)      $��	60,60,0,0q�6!   .+�5+      � -   5        $ GridAssistant��5+      5?      � 5@      -   5        $ GridPrincipal��5A      $
��1020��5B      $	��676��5C      $��Center=�5D      $��Center=�5E       J� RenderTransformOrigin$ 0.5,0.5&�5F       � RowDefinitions 5G      �� 5H      $	��27* �6$   �� 5I      $
��142* �6$   .+�5L      � -   5        $ TopModifyContainer��5L      $��0��63    � ColumnDefinitions 5M      �� 5N      $��2* �6+   �� 5O      .+�5S      � $��0��6   $��
0,10,10,22q�6+   .+�5U      � -   5        $ SearchBoxContainer��5V      $	��514��5W      $��65��5X      $��Center=�5Y      $��Center=�5Z      .+�5[      �� 
������� �� CornerRadius$ 20��6<   ._�5\   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5]   &      QuanLyNhaHang.SearchBox  $��Center=�66   �� 5^   &   -   5         ��Name$ 	searchTxb��5_   )   $	��500��5`   )   $
��Left=�5a   )   $��Center=�5b   )   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Type to search��5c   )   $��19(�5d   )   $
��Bold"�5e   )   6;   5f   #   5h      5i      5k      �� 5m      -   5         ��Name$ 	AddButton��5n      $��1��5o      $	��146��5p      $��45��5q      $��0,0,20,0q�5r      $��Right=�5s      $��Center=�5t      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25��5u      ���	#FF17A282 " MaterialDesignRaisedDarkButton#��[ 5x       � ToolTip$7 1MaterialDesignRaisedDarkButton with Round Corners��5y      .��5z      �� $ 
Horizontal=�6%   .+�5{      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ AddFieldIcon��5|   !   $��34��5}   !   $��41��5~   !   $
��Left=�5   !   
�������   Kind$
 Plus=�5�   !   �� 5�      $��41��5�   !   $��20��5�   !   $��5,0,15,0q�5�   !   
������� � LayoutTransform 5�   "   �� 5�   &    �� Angle$ 90Q�66   5�      �� 5�      $��Center=�5�   !   $��Center=�5�   !   
�������$	��New��5�   !   5�      5�      5�      � 5�      -	   5        $ BottomModifyContainer��5�      $��1��5�      $
��1010��5�       5�      �� 5�      $	��49* �6(   �� 5�      $
��519* �6(   .+�5�      � -
   5        $ ManagerFieldHolder��5�      $��0��67   .+�5�          QuanLyNhaHang.TableManager  5�      �� 5�      -   5         ��Name$ CardContainer��5�   #   $��1��6:   .��5�      �� -   5         ��Name$ 
ListHolder��5�   %   $ Vertical=�69   .+�5�          QuanLyNhaHang.CategoryCard  5�      5�      5�      5�      5�      � 5�   
   $��60��5�      $	��Top=�5�      ���	#FFDA8046 J� Effect 5�      3  -System.Windows.Media.Effects.DropShadowEffect  5�         
BlurRadius$ 1Q�5�         ShadowDepth$ 1Q�5�         Color$ 	#FFACACAC��5�      .+�5�      �� $��Center=�5�      $��Center=�5�      $��35(�5�      
�������$��Restaurant management��5�      �� 5�      $��Right=�6   $ 
Horizontal=�65   .+�5�      �� $��Center=�5�      $��18(�5�      
�������$�� Admin��5�      '	  !MaterialDesignThemes.Wpf.PopupBox	  5�      $��5q�5�      
�������  	  PlacementMode$  BottomAndAlignRightEdges=�5�      ! 	  	StaysOpen$! False��5�      " 	  PopupContent." 5�      �� $	��150��6!   .+�5�      �� $��Account detail��6!   �� 5�      $��Change password��6!   �� 5�      �� 5�      -   5        $ LogoutButton��5�      $��Logout��5�      # � Cursor$
# Hand��5�      5�      5�      5�      5�      � 5�   
   -   5        $ GridMenu��5�      $��65��5�      $
��Left=�5�      ���	#FFDA1B1B 5�        5�      $ 2Q�5�      $ 1Q�5�      $ 	#FFAEAEAE��5�      .+�5�      �� .+�5�      � $	��160��5�      
�������$ 0.5,0.5&�5�      z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      T� 5�      5�      .+�5�      �� -   5        $ ButtonOpenMenu��5�      $��60��5�      $��60��5�      $��Right=�5�      $	��Top=�5�       0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5�      ��5�      Z� ��5�      Z� .��5�        $��25��5�      $��25��5�      ���#FF1B38$
 Menu=�5�      5�      �� 5�      -   5        $ ButtonCloseMenu��5      $��60��5     $��60��5     $��Right=�5     $	��Top=�5     #��[ 5     $y�	Collapsed=�5	     ��5     Z� ��5     Z� .��5
       $��25��5     $��25��5     ���#FF1B38$ 	ArrowLeft=�5     5     �� 5     $��80��6   $��Bottom=�6(   5     �� 5     -   5        $ ��Name$$ ListViewMenu��5     $��Disabled=�5     .@�5     �� $	��60 ��6#   ���	#FFDA1B1B.��5     �� $ 
Horizontal=�6%   .+�5       $��25��5  !   $��25��5  !   $��10q�5  !   $��Center=�5  !   ���	#FFD4C0C0$
 Home=�5  !   �� 5      $��20,10q�5!  !   ���	#FFD4C0C0$
��Home��5#  !   5$     5%     �� 5&     $	��60 ��6#   ���	#FFDA1B1B.��5'     �� $ 
Horizontal=�6%   .+�5(       $��25��5)  !   $��25��5*  !   $��10q�5+  !   $��Center=�5,  !   ���	#FFD4C0C0$	 Man=�5.  !   �� 5/     $��20,10q�50  !   $��Center=�51  !   ���	#FFD4C0C0$��Staff��53  !   54     55     �� 56     $	��60 ��6#   ���	#FFDA1B1B.��57     �� $ 
Horizontal=�6%   .+�58       $��25��59  !   $��25��5:  !   $��10q�5;  !   $��Center=�5<  !   ���	#FFD4C0C0$
 Meat=�5>  !   �� 5?     $��20,10q�5@  !   ���	#FFD4C0C0$
��Meal��5B  !   5C     5D     �� 5E     $	��60 ��6#   ���	#FFDA1B1B.��5F     �� $ 
Horizontal=�6%   .+�5G       $��25��5H  !   $��25��5I  !   $��10q�5J  !   $��Center=�5K  !   ���	#FFD4C0C0$ Shape=�5M  !   �� 5N     $��20,10q�5O  !   ���	#FFD4C0C0$��Category��5Q  !   5R     5S     �� 5T     $	��60 ��6#   ���	#FFDA1B1B.��5U     �� $ 
Horizontal=�6%   .+�5V       $��25��5W  !   $��25��5X  !   $��10q�5Y  !   $��Center=�5Z  !   ���	#FFD4C0C0$ 
TableChair=�5\  !   �� 5]     $��20,10q�5^  !   ���	#FFD4C0C0$��Table Status��5`  !   5a     5b     �� 5c     $	��60 ��6#   ���	#FFDA1B1B.��5d     �� $ 
Horizontal=�6%   .+�5e       $��25��5f  !   $��25��5g  !   $��10q�5h  !   $��Center=�5i  !   ���	#FFD4C0C0$ Account=�5k  !   �� 5l     $��20,10q�5m  !   ���	#FFD4C0C0$��Account��5o  !   5p     5q     �� 5r     $	��138��6    �� 5s     $��Center=�5t     $��Center=�5u     $
��Bold"�5v     ���	#FFD4C0C0$��v1.0.0��5x     5y     5z     5|     5}     5~     