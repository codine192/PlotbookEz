   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EzPlot.ViewsEzPlot.Views  5      &     EzPlot.Views.AddResidentPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:EzPlot.Views     5        N� Title$  AddResidentPageView��5
       � DataContext 5      ��  �� RelativeSource �� *Self+ � 	Resources 5       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%N  '��       '��     '  (    �� 5   
   CornFlowerTextBox��" ��6+   .�5      ��  � ��
 ��d�6E   �� 5       � ��$ 2q�60   �� 5       � ��$ 3q�6'   �� 5       � ��$	 250��6&   �� 5       � ��$ 30��6'   �� 5       � ��$
 Left=�64   5      �� 5   
   	Label��" ��6   .�5      ��  � ��
 ��d�6E   �� 5       � ��$ 2q�60   �� 5       � ��$ 3q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$
 Left=�64   �� 5       � ��$ Yu Gothic UI)�6+   5      �� 5   
   Date��"  6   .�5      ��  � ��
 ��d�6E   �� 5       � ��$ 2q�60   �� 5        � ��$ 3q�6'   �� 5!       � ��$	 150��6&   �� 5"       � ��$ 30��6'   �� 5#       � ��$
 Left=�64   5$      5%      .��5&      � ���	#FF0C757D.+�5'   
   �� 
����d�$��3q�6.   ._�5(      � $��15q�6   $��Center=�6    $��Center=�6;    J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*         
BlurRadius$ 50Q�6'   ��5,      �� 5-      	 �� EndPoint$	 0.5,1&�6*   
 �� 
StartPoint$
 0.5,0&�6;   .��5.      �  � Color$ 	#FFB6BBFF��6'    � Offset$ 1Q�69   � 5/      $ 	#FFBBEDF3��6'   $ 0Q�69   50       � ColumnDefinitions 53      �� 54      $	��10* �6'   65   �� 55      $	��20* �6'   65   �� 56      $	��20* �6'   65   �� 57      $	��20* �6'   65   �� 58      $	��20* �6'   65    � RowDefinitions 5:      �� 5;      $	��83* �6$   63   �� 5<      $	��83* �6$   63   �� 5=      $	��83* �6$   63   �� 5>      $	��83* �6$   63   �� 5?      $	��83* �6$   63   �� 5@      $	��83* �6$   63   �� 5A      $	��83* �6$   63   .+�5C      �� $�� ADD RESIDENT��6   $��40(�60   $��3��6>   $��2��6N   $��3,3,0,3q�6b   $	��NaN��6s   ���	#FF0C757D$��0q�6�   $��Cambria)�6�   ���	#000000006�   �� 5D      $��0��6   $��0��6-   $��3��6<   $��7��6P   $��Center=�6a   .+�5E      9�  9� ExpandDirection$ Up=�6   $��Resident��64    9� 
IsExpanded$
 True��6F   .��5F      ]� .+�5G      �� $
��Left=�6)   .+�5H   "   �� $��
First Name��6(   �� 5I   "   $��	Last Name��6(   �� 5J   "   $	��DOB��6(   �� 5K   "   $	��DOD��6(   �� 5L   "   $��
Date Added��6(   5O      �� 5P      $��Right=�6)   .+�5Q   "   ��  �� CharacterCasing$ Upper=�6E   ��6*   �� *	FirstName+6E   �� 5R   "   $ Upper=�6D   ��6*   �� *
LastName+6D     5S   "      SelectedDate 6-   �� *DOB+  5T   "    6-   �� *DOD+�� 5U   "   ��6*   �� *	DateAdded+5X      5Y      5Z      9� 5[      $��Contact��6   $
 Down=�60   $
 True��6G   .��5]      ]� .+�5^      �� $
��Left=�6)   .+�5_   "   �� $��First Name:��6(   �� 5`   "   $��
Last Name:��6(   �� 5a   "   $��Phone:��6(   �� 5b   "   $��Email:��6(   �� 5c   "   $��Street Address:��6(   �� 5d   "   $��State:��6(   �� 5e   "   $
��Zip:��6(   5f      �� 5g      $��Right=�6)   .+�5h   "   �� ��6*   �� *ContactFirstName+6N   �� 5i   "   ��6*   �� *ContactLastName+6M   �� 5j   "   ��6*   �� *ContactPhone+6K   �� 5k   "   ��6*   �� *ContactEmail+6K   �� 5l   "   ��6*   �� *ContactAddress+6M   �� 5m   "   ��6*   �� *ContactState+6K   �� 5n   "   ��6*   �� *
ContactZip+6I   5o      5p      5s      5t      �� 5v      -   5        $��3��5v      $��6��6*   $��2��67   $��Cancel��6h   $��25��6y   $��70��6�   
����d�$��3q�6�   �� 5w      -   5        $��4��5w      $��6��6*   $��2��67   $
��Save��6f   $��25��6u   $��70��6�   
����d�$��3q�6�   �� 5y      -   5         ��Name$ headStoneContainer��5y      $��UniformToFill=�6Q   $��3��6i   $��1��6y   $��2��6�   $��5��6�   $��	0,78,19,0q�6�   ��64   �� *	HeadStone+6�   �� 5z      -   5         ��Name$ uploadButton��5z      $��Upload Headstone��6Q   $��3��6l   $��3��6|   $��2��6�   $��0,0,10,0q�6�   5�      5�      5�      5�      