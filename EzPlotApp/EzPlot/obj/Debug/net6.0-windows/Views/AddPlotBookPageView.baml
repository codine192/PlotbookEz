   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EzPlot.ViewsEzPlot.Views  5      &     EzPlot.Views.AddPlotBookPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:EzPlot.Views     5        N� Title$  AddPlotBookPageView��5
       � DataContext 5      ��  �� RelativeSource �� *Self+ � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName��%�  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   #��z��6/   #��z��5      $��2q�5      $ 10��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=   . �5   "   �� $ border��6)    � ��
 ��d�6S   5      5      5      5      5      .��5!      � 
������� � ColumnDefinitions 5"   
   �� 5#      $	��20* �6   �� 5$      $	��20* �6   �� 5%      $	��20* �6   �� 5&      $	��20* �6   �� 5'      $	��20* �6    � RowDefinitions 5)   
   �� 5*      $	��10* �6   �� 5+      $	��10* �6   �� 5,      $	��10* �6   �� 5-      $	��10* �6   �� 5.      $	��10* �6   .+�50   
   �� $��Add PlotBook��6   $��0��6'   $��1��64   $��3��6D   $��Center=�6X   $��35(�6u   $��Cascadia Mono SemiLight)�6�   �� 51   
   $��Cemetary��6   $��1��6#   �� 52   
   $��1��6   $��1��6    $��25��6y   $	��Top=�6�    �� DisplayMemberPath$
 Name��6�    �� SelectedValuePath$ ID��6�   ��60   �� *
Cemeteries+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 6�   �� *
SelectedID+�� 53   
   $
��Name��6   $��2��6   �� 54   
   $��2��6   $��1��6   $��25��6o   $	��Top=�6{   ��6/   �� *	NameOfCem+$ PropertyChanged=�6{   �� 55   
   $��Arial��6   $��3��6    $��0��6-   �� 56   
   -   5        $��1��56      $��3��6!   $��Select Photo��6.   6E   �� 57   
   -   5        $��4��57      $��4��6!   $
��Save��6.   6=   �� 59   
   $��2��6   $��1��6    $��3��6-   $��3��6A   $��Center=�6�   $	��200��6�   $	��300��6�   ��6R   �� *UploadedImage+$ PropertyChanged=�6�   5;      5<      