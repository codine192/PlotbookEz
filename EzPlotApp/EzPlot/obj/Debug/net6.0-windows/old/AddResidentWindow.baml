   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EzPlot.ViewModelsEzPlot.ViewModels  5   	   $    EzPlot.Views.AddResidentWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6
viewmodelsclr-namespace:EzPlot.ViewModels     5   	     � Title$  Add Resident��5   	   $	��530��6   $	��600��6+   .��5	      � $��0,0,0,14q�6    � ColumnDefinitions 5
   
   �� 5      $	��26* �6   �� 5      $��3* �6   �� 5      $	��11* �6   .+�5   
   �� -   5         ��Name$ AddResidentTitle��5      $��Add Resident��6*   $
��Left=�6A   $��34��6\   $��	20,10,0,0q�6h   $	��Top=�6{   $	��225��6�   $
��Bold"�6�   $��Cascadia Code)�6�   $��20(�6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��385��6T   $��	20,49,0,0q�6a   $	��Top=�6t   $	��560��6�   $��3��6�   ._�5      � $��	-1,-1,1,1q�6   .+�5      �� $��First Name :��6   $
��Left=�6/   $��23��6J   $��	10,10,0,0q�6V   $	��Top=�6i   $��84��6�   $��Cascadia Code)�6�   �� 5      $
��Left=�6   $��26��65   $��	114,7,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6�   $	��145��6�   ��6h   �� *	FirstName+6�   �� 5      $��	Last Name��6   $
��Left=�6,   $��25��6G   $��	10,58,0,0q�6S   $	��Top=�6f   $��84��6~   �� 5      $��Birthday��6   $��25��6+   $��10,103,478,0q�67   $	��Top=�6M   �� 5      $
��Left=�6   $��25��65   $��
114,58,0,0q�6A   $
 Wrap=�6U   $	��Top=�6�   $	��145��6�    J� RenderTransformOrigin$ 0.483,-0.606&�6�   ��6i   �� *
LastName+6�   �� 5      $
��Left=�6   $��22��66   $��114,276,0,0q�6B   $	��Top=�6W   $	��179��6o   �� 5      $��Plot ID��6   $
��Left=�6*   $��30��6E   $��
14,278,0,0q�6Q   $	��Top=�6e   $��80��6}   �� 5      $��Deathday��6   $
��Left=�6+   $��25��6F   $��
10,153,0,0q�6R   $	��Top=�6f   $	��105��6~   �� 5      $��Move In Day��6   $
��Left=�6.   $��30��6I   $��
14,328,0,0q�6U   $	��Top=�6i   $��95��6�   �� 5      $
��Left=�6   $��35��65   $��114,323,0,0q�6A   $
 Wrap=�6V   $	��Top=�6�   $	��145��6�   ��6j   �� *	DateAdded+6�   �� 5      $��Full Name :��6   $
��Left=�6.   $��25��6I   $��
293,33,0,0q�6U   $	��Top=�6i   $��86��6�   �� 5      $
��Left=�6   $��25��65   $��
379,33,0,0q�6A   $
 Wrap=�6U   $	��Top=�6�   $	��135��6�   ��6i   �� *
FullName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5      $
��Left=�6   $��
85,104,0,0q�68   $	��Top=�6L   ���	#FF447392   SelectedDate 6d   �� *	BirthDate+6�     5       $
��Left=�6   $��
85,153,0,0q�68   $	��Top=�6L    6d   �� *	DeathDate+5!      5"      � 5#   
    � 	StaysOpen$ False��6+   $��Center=�6=   ��6   �� *	IsSaved+.��5%      �� 
�������$	��300��6(   $	��200��64    �� CornerRadius$ 5��6A   ._�5&      �� .+�5'      �� $��Resident saved!��6    $��Center=�67   $��Center=�6T   �� 5(      $��Close��6   $��Center=�6e   $��10q�6�   ��6-   �� *%#CloseSaveResidentConfirmationWindow+6�   5)      5*      5+      �� 5,   
   $��2��6   $
��Save��6!   $
��Left=�60   $��31��6K   $��
50,439,0,0q�6W   $	��Top=�6k   $��95��6�   ��6�   �� *SaveNewResidentCommand+5.      50      