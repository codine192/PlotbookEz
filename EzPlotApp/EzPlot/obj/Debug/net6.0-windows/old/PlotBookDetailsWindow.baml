   M S B A M L   `   `   `  ����A  =EzPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:EzPlot.ViewModelsEzPlot.ViewModels  5   	   5clr-namespace:EzPlot.ViewModelsEzPlot.ViewModels  5   	   (    "EzPlot.Views.PlotBookDetailsWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6
viewmodelsclr-namespace:EzPlot.ViewModels     5   	   .vmclr-namespace:EzPlot.ViewModels     5   	     � Title$  PlotBook Details��5   	   $	��450��6"   $	��800��6/   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Upload Aerial Image��6   $��0��6/   $��5q�6<   ��6G   �� *FindAerialCommand+�� 5   
   -   5        $��plotBookName��5      $��1��6&   $��5q�63   ��6>   �� *Name+�� 5   
   -   5        $��plotBookCemeteryID��5      $��2��6,   $��5q�69   ��6D   �� *
CemeteryID+�� 5   
   $
��Save��6   $��3��6    $��5q�6-   $��Bottom=�68   ��6S   �� *SavePlotBookCommand+� 5    
    � 	StaysOpen$ False��6+   $��Center=�6=   ��6   �� *	IsSaved+.��5"      �� 
�������$	��300��6(   $	��200��64    �� CornerRadius$ 5��6A   ._�5#      �� .+�5$      �� $��Resident saved!��6    $��Center=�67   $��Center=�6T   �� 5%      $��Close��6   $��Center=�6g   $��10q�6�   ��6-   �� *'%CloseSavePlotBookConfirmWindowCommand+6�   5&      5'      5(      5)      5+      