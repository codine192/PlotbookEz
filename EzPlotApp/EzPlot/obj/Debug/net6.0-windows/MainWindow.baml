   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EzPlot.ViewsEzPlot.Views  5   	       EzPlot.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EzPlot.Views     5   	   $��Yu Gothic UI)�5   	   $��14(�5	   	     � Title$  EzPlot��5   	   $	��750��6   $
��1150��6(    � DataContext 5   	   ��  �� RelativeSource �� *Self+ � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName �� 	ClickMode d� 	IsChecked �� Path �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly ��Name �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation��%�  '��       '�� �    �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   #��z��6/   #��z��5      $��2q�5      $ 10��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � ��
 ��d�6S   5      5      5      5       �� 5!   
   " ��6   .�5"      ��  � �� 5#      �� 5$      " ��6&   .R�5%      �� $ 8��6!   #��z��62   
���**��._�5&      � .+�5'   "   d� $��2��60   $|�false��6@   $ Press=�5)   !    5(   !   �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+��5*   &   �� 5+   *   .R�5,   .   F� $��Steve��63   
����d�$��Center=�6W   $��Center=�6t   "����        � 	=  	= � z     	6�   5-   +   5/   #   �� 50   "   $��ContentSite��63   $ False��6G   #��z 51   !   #��z 6N   #��z��52   !   $��3q�6b   $��Center=�6m   $
��Left=�6�   �� 53   "   $ PART_EditableTextBox��6*   $��3q�6H   $��Center=�6S   $
��Left=�6n   
������ $
|�True��54   !   $y�Hidden=�62   # z 6F   .��6p   ��55   &   �� 56   *   .R�57   .   �� $ PART_ContentHost��65   $|�False��6O   58   +   .��59   8   5:   #   � 5;   "   $��Popup��6(   $��Bottom=�65   #��z 6H   $
 True��6r   $|�False��5<   $   $��Slide=�66   .��5=   &   � $��DropDown��6+   $
 True��6;   #��z 6V   #��z 6   .+�5>   *   �� $ DropDownBorder��61   
�������$��1q�6\   $ 8��6p   �� 5?   *   $	��4,6q�67   $
 True��6D   .��5@   .   �� $
 True��69   $ 	Contained=�6L   5A   +   5C   '   5D   #   5E      5F      5G      5I      5J      5O      .��5P      �� 
����d�$��2q�6*   ._�5Q   
   � $
��Auto��6   $
��Auto��6   ���	#FF0C757D � ColumnDefinitions 5R      �� 5S      $
��Auto �6#   �� 5T      $
��100* �6#   �� 5U      $
��100* �6#   �� 5V      $
��100* �6#     � RowDefinitions  5X      �� 5Y      $
��100* �6    �� 5Z      $
��100* �6    �� 5[      $	��100 �6    .+�5^      �� ! �� Orientation$! Vertical=�6   $��Center=�60   $	��150��6N   $
��Auto��6Z   
����d�$��3��6�   .+�5_      �� -   5        $��Add Resident��5_      $��5q�60   $	��100��6`   $��Yu Gothic UI)�6l   $��14(�6�   �� 5`      -   5        $��View Residents��5`      $��5q�62   6>   �� 5b      -   5        $��
View Plots��5b      $��5q�6.   6:   5e       � 5f      -   5        $��	MainFrame��5f   V   $��0��6   $��1��6!   $��3��61   $��3��6E   "  � NavigationUIVisibility$" 	Automatic=�6g   $
��Auto��6�   $
��Auto��6�   
����d�6�   �� 5g      -   5        $��Change PlotBook��5g      $��0��6/   $��4��6]   $��25��6j   $	��top=�6v   �� 5h      -   5        $	��Map��5h      $��0��6#   $��4��63   $��25��6@   $	��150��6h   �� 5i      -   5        $��Add PlotBook��5i      $��5q�6,   $��0��67   $��1��6G   $��25��6T   $��Bottom=�6�   � 5j      -   5        # �Name$# LoadPlotBook��5j      $��Mouse=�6+   $��Slide=�6=   $
 True��6T   .��5k      ]� $
��Auto��6   $
��Auto��6+   .+�5m      �� $
��Left=�6$   $��1��6:   $��30��6G   $	��150��6S   $ �� DisplayMemberPath$
$ name��6�   ��6_   �� *	PlotBooks+% �� SelectedItem% 6�   �� *SelectedPlotBook+5o      �� 5q      -	   5        $��Right=�5q      $
��Load��64   $��40��6f   6s   �� 5r      -
   5        $��Right=�5r      $��Cancel��6S   $��60��6d   6q   5s      5t      5x      5y      5{      