   M S B A M L   `   `   `  ����H  DQuanLyNhaHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:QuanLyNhaHangQuanLyNhaHang  5   	       QuanLyNhaHang.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:QuanLyNhaHang     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F   .��5
      � .+�5   
   �� $	��300��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFD12222��6#   67   � 5      $ 	#FF8A3F26��6#    � Offset$	 0.5Q�65   6D   � 5      $ 	#FF8B4828��6#   $ 1Q�65   6B   5      5      �� 5   
   $��Assets/restaurant.png��6   $	��100��6/   $	��100��6;   $	��Top=�6H   $��125,10,125,0q�6`    J� RenderTransformOrigin$ 
0.55,-0.25&�6v   5      �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusX$ 15��6d   	 �� RadiusY$	 15��6q   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��LOGIN��6   $��Center=�6%   $	��Top=�5      $��5q�60   
�������$��18(�5   +   $
��Bold"�5      6,   � 5       $��Center=�6   $��10,0,0,0q�6.    � RowDefinitions 5!      �� 5"      6&   �� 5#      6&   �� 5$      6&   .+�5&      �� -   5        $��usernameContainer��5&      $
��Left=�63   $��Center=�6N   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ USERNAME��5'      $��	0,10,0,10q�5(      $	��250��6-   $��0��69   $��1��6F   .��6S   5)      �� 5*      -   5         ��Name$ passwordStack��5*      $	��250��61   $��1��6=   $
��Left=�6J   .+�5+      � -   5         �Name$ passwordContainer��5+      .+�5,      �� -   5         ��Name$ txbPassword��5,   "   $
��Left=�67   $��Center=�6R   ��5-   "   �� *ActualWidth+ �� ElementName$ passwordStack��G� 5.      -   5         G�Name$ passwordBox��5.   &   $
��Left=�6;   $��Center=�50   &   $ PASSWORD��51   &   $��2��6P   ��5/   &   �� *ActualWidth+$ passwordStack��51   P   52      �� 53      -   5         ��Name$ passwordVisability��53      $��45��69   $��42��6D   
������� �� Left$	 218��6�   
 �� Top$	 -11��6�   ��6   Z� .��54      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ passwordShow��54   2      Kind$ EyeOff=�6H   $��Center=�6V   $��15��6q   $��23��6|   $��Center=�6�   55      56      �� 57      $��Remember Password��6   $��15(�67   $��2��6E   $��0,40,0,0q�6R   $��3��6d   58      5:      �� 5;   
   -   5        $��Bottom=�5;      $
��0,85q�6,   $	��150��5<      $��LOGIN��6   ���	#FFF36521���	#FFF3B021 �� 	IsDefault$
 True��5>   %   $��4��66   6E   �� 5?   
   $��FORGOT YOUR PASSWORD?��6   $��Center=�61   $��Bottom=�6N   $��50q�6i   $��15(�6u   
�������$
��Bold"�6�    � Cursor$
 Hand��6�   6�   5@      5A      