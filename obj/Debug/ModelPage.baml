   M S B A M L   `   `   `  ����K  GFinal_Project_UP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Final_Project_UPFinal_Project_UP  5           Final_Project_UP.ModelPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Final_Project_UP     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  	ModelPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      $��4* �6   6*    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ producer��5      $��1��6$   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  Производитель��61   $��Bottom=�6`    �� SelectionTextBrush �	#03FFFFFF6�   �� 5   
   -   5        $
 mark��5      $��1��6    $��1��60   $ 
Марка��6=   $��Bottom=�6d    �	#03FFFFFF6�   �� 5   
   -   5        $ 	max_speed��5      $��2��6%   $��1��65   $/ )Максимальная скорость��6B   $��Bottom=�6y    �	#03FFFFFF6�   �� 5   
   -   5         ��Name$ Create��5      $��Создать��6!   $	��NaN��63   $��1��6U   6k   �� 5   
   -   5        $ Change��5      $��Изменить��6!   $��1��64   $	��NaN��6D   $��1��6f   6|   �� 5   
   -   5        $ Delete��5      $��Удалить��6!   $��2��63   $	��NaN��6C   $��1��6e   6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGrid��5      $��2��6P   $��4��6]   6q   5      5      