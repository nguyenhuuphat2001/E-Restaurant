   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5      =#clr-namespace:QuanLyNhaHang.UI.MealQuanLyNhaHang.UI.Meal  5      #    QuanLyNhaHang.TableManagement   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:QuanLyNhaHang     5      6local1#clr-namespace:QuanLyNhaHang.UI.Meal     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      -   5          �Name$  TableManagerment��5         tbVM � DataContext# [  5       � Title$ TableManagement��5      $
��1050��5      $	��700��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   � $��0��5      $	��Top=�5      ���	#FFDA8046 J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 1Q�5      	   ShadowDepth$	 1Q�5       
   Color$
 	#FFACACAC��5!      .+�5#      �� $��Center=�5$      $��Center=�5%      $��35(�5&      
�������$��Waiter's form��5(      �� 5)      $��Right=�6    �� Orientation$ 
Horizontal=�65   .+�5*      �� $��Center=�5+      $��18(�5,      
�������$��waiter��5.      '  !MaterialDesignThemes.Wpf.PopupBox  5/      $��5q�50      
�������   PlacementMode$ BottomAndAlignRightEdges=�52         	StaysOpen$ False��53         PopupContent. 54      �� $	��150��6!   .+�55      �� $��Account detail��6!   �� 56      $��Change password��6!   �� 57      �� 58      -   5         ��Name$ LogoutButton��59      $��Logout��5;       � Cursor$
 Hand��5<      5=      5>      5?      5@      � 5A   
   $��1��6   .  (System.Windows.Interactivity.Interaction   Triggers 5B      /  )System.Windows.Interactivity.EventTrigger  5C         	EventName$ Loaded��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5D      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *GetTableManagement+   CommandParameter 5E      ��  �� ElementName$ TableManagerment��5F       � ColumnDefinitions 5H      �� 5I      $��7* �6#   �� 5J      �� 5L      $��9* �6#   .+�5N      �� 
������� �� CornerRadius$ 10��6'   ._�5O      �� $��0��6   .��5P      � -   5         �Name$ wpTable��5P        � Orientation$ 
Horizontal=�61   $��20q�6J   .+�5Q         QuanLyNhaHang.Table  $��5q�6&     5R      $��5q�6&     5S      $��5q�6&   5T      5U      5V      �� 5X      $��1��6    � LayoutTransform 5Y      �� 5Z       �� Angle$ 90Q�6&   5\      �� 5_      $��2��6   $	��616��6(   $��0,2,0,0q�65   $	��Top=�6F    5`      �� 5a      $ 90Q�6&   5c      � 5e      $��3��5f      $��2��5g      $��40,0,0,0q�5h       5j      �� 5k      $��3* �6$   �� 5l      $��5* �6$   �� 5m      $��2* �6$   .+�5o      � -   5         �Name$ orderFieldContainer��5o      $��0��64    5p      �� 5q      $��2* �6+   �� 5r      .+�5u      � $��0��6    5v      �� 5w      $��30 �6,   �� 5x      $��30 �6,   �� 5y      $��30 �6,   �� 5{      .+�5}      �� -   5         ��Name$ 
cbCategory��5~      $��0��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Select category��5�          HintOpacity$	  .26Q�5�      ! �� 
IsEditable$
! True��5�      5�      �� 5�      -   5        $ cbFood��5�      $��1��5�      $ Select Food��5�      $	  .26Q�5�      $
! True��5�      5�      �� 5�      -   5        " ��Name$" txbQuantity��5�      $��2��5�      $ Input quantity��5�      # �� AcceptsReturn$
# True��5�      $ �� MaxLines$$ 1��5�      % �� TextWrapping$
% Wrap=�5�      �� 5�      -   5        $" addtionalNoteTextbox��5�      $��3��5�      &   
HelperText$& Special requirement��5�      $ Additonal note��5�      $
# True��5�      $
% Wrap=�5�      "' �� VerticalScrollBarVisibility$' Visible=�5�      5�      �� 5�      -	   5        $��1��5�      $��60��5�      $��Center=�5�      $��Center=�5�      $��Confirm��5�      $
��Bold"�5�      
�������5�      5�      � 5�      $��2��6   $��
0,212,0,10q�6(    5�      �� 5�      $��* �6(   �� 5�      $��5* �6(   .+�5�      � -
   5        $! MealStatusMangagerContainer��5�      $��0��5�      $��0,0,0,0q�5�      .+�5�      %	   QuanLyNhaHang.MealStatusManager	  $��Center=�62   5�      �� 5�      -   5        ( ��Name$( MealStatusCardContainer��5�   #   $��1��6D   .��5�      �� -   5        ) ��Name$) spmealstatus��5�   %   $ Vertical=�6;   .+�5�      "
   QuanLyNhaHang.MealStatusCard
  
  5�      
  5�      5�      5�      5�      � 5�      $��2��6    5�      �� 5�      �� 5�      �� 5�      .+�5�      � $��0��6   $��2q�6+    5�      �� 5�      �� 5�      �� 5�      .+�5�      #  MaterialDesignThemes.Wpf.Card  $��30��5�      $��Center=�5�      ���	#FF17A282.��5�      �� $��Center=�5�   !   $��Center=�5�   !   $
��Bold"�5�   !   
�������$��Change table��5�   !   5�      � 5�      $��1��6   .+�5�         QuanLyNhaHang.SelectTable  -   5        *  Name$* 	ucCbTable��5�   0   $��50��6C   5�      �� 5�      -   5        $��2��5�      $��3q�5�      $��Stretch=�5�      $��Center=�5�      $��Change��5�      $
��Bold"�5�      
�������5�      5�      � 5�      $��1��6   $��2q�6+    5�      �� 5�      �� 5�      �� 5�      .+�5�        $��30��5�      $��Center=�5�      ���	#FF17A282.��5�      �� $��Center=�5�   !   $��Center=�5�   !   $
��Bold"�5�   !   
�������$��Discount��5�   !   5�      � 5�      $��1��6   .+�5�      !   QuanLyNhaHang.DiscountField  -   5        +  Name$+ discount��5�   2   $��50��6D   5�      �� 5�      -   5        $��2��5�      $��3q�5�      $��Stretch=�5�      $��Center=�5�      $��Apply��5�      $
��Bold"�5�      
�������5�      5�      � 5�      $��2��6   $��2q�6+    5�      �� 5      �� 5     �� 5     $��40 �6,   .+�5       $��30��5     $��Center=�5     ���	#FF17A282.��5     �� $��Center=�5	  !   $��Center=�5
  !   $
��Bold"�5  !   
�������$��Total��5  !   5     �� 5     -   5        , ��Name$, Price��5     $��1��5     $��Stretch=�5     $��Center=�5     $��19(�5     $
��Bold"�5     $��
100000 VND��5     - �� TextAlignment$- Center=�5     $
��Wrap=�5     �� 5     -   5        $��2��5     $��Export bill��5     $
��Bold"�5     
�������5     5      5!     5#     5$     5%     5&     