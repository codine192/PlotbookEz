   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:EzPlot.ControlsEzPlot.Controls  5      +clr-namespace:EzPlot.ViewsEzPlot.Views  5      Q-clr-namespace:EzPlot.Controls.ToolbarControlsEzPlot.Controls.ToolbarControls  5          EzPlot.Views.MainPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      1controlclr-namespace:EzPlot.Controls     5      Q MControlzEx, Version=4.0.0.0, Culture=neutral, PublicKeyToken=69f1c32f803d307e
controlzexurn:controlzex  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      &localclr-namespace:EzPlot.Views  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
      ;toolbar-clr-namespace:EzPlot.Controls.ToolbarControls  5      -   5          N�Name$
  Self��5       N� Title$ MainPage��5       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType � ColumnDefinitions � RowDefinitions	 ��Name
 �� ScrollableHeight � Maximum �� Orientation �� ViewportHeight �� ViewportSize* �� #ComputedVerticalScrollBarVisibility �� VerticalOffset � Value �� ScrollableWidth �� ViewportWidth, �� %ComputedHorizontalScrollBarVisibility �� HorizontalOffset��%�  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �  5      �� 5   "   $��* �63   �� 5   "   $
��Auto �63    5      �� 5   "   $��* �60   �� 5   "   $
��Auto �60   .+�5      �� $��0��5   !   $��0��5   !   #��z��5    !   #��z��5!   !   �� 5"      $	 PART_VerticalScrollBar��5#   !   $��0��5$   !   $��1��5%   !   $	��300��5&   !   # z
 5'   !   $ Vertical=�5(   !   # z 5)   !   #y�z 5*   !   # z 5+   !   �� 5,      $	 PART_HorizontalScrollBar��5-   !   $��1��5.   !   $��0��5/   !   $	��300��50   !   # z 51   !   $ 
Horizontal=�52   !   # z 53   !   #y�z 54   !   # z 55   !   56      57      59      5:      5;      .��5=      �� $��1q�5>   	   
����d�$��1q�5@   	   ._�5A   
   � $
��Auto��5B      $
��Auto��5C      ���	#FF0C757D � DataContext 5E      ��  �� ElementName$
 Self��.+�5F      (� .��5G      �� $��10q�5H      $��10q�5I      $��Center=�5J      $��Center=�5K      $
��Auto=�5L       �� PanningMode$
 Both=�5M      $
��Auto=�5N      .��5O      � .+�5P      �� -   5         ��Name$ OverlayCanvas��5Q      $	��850��5R      $	��550��5S      $��20q�5T      $��Center=�5U      $��Center=�5V      
������� J� Effect 5Y      3  -System.Windows.Media.Effects.DropShadowEffect  5Z   "      
BlurRadius$ 35Q�63    � LayoutTransform 5\      �� 5]   "    �� ScaleX 61   �� *Value+$ 
ZoomSlider�� �� ScaleY 6b   �� *Value+$ 
ZoomSlider��.+�5_      �� -   5         ��Name$ mapImage��5`   !   $	��850��5a   !   $	��550��5b   !   $��UniformToFill=�5c   !   5e      5g      5i      5j      �� 5k      -   5          ��Name$  
ZoomSlider��5l      $��20��5m      $	��150��5n      $��3q�5o      $��2q�5p      $
��Left=�5q      ���	#FF279ED0$ 10Q�5t      ! � Minimum$! .9Q�5u      " �� Orientation$" Vertical=�5v      $ .5Q�5w      ��5r      Z�  5y      -  'System.Windows.Media.Effects.BlurEffect  5z      5|      9   3EzPlot.Controls.ToolbarControls.ToggleSwitchControl  5}      -   5        #  Name$# toggleSwitch��5}   *   $	��Top=�6@   $
��left=�6X   6u   *   $EzPlot.Controls.MarkerToolBoxControl  5~      -   5        $  Name$$ markerToolBoxControl��5~   +   $	��Top=�6I   D   >EzPlot.Controls.ToolbarControls.CemeteryPlottingToolbarControl  5      -   5        %  Name$% PlottingToolBar��5   5   $��Bottom=�6N   5�      5�      5�      