   M S B A M L   `   `   `  ����M  Ipresentation-Serie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:presentation_Seriepresentation_Serie  5   	   #    presentation_Serie.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:presentation_Serie     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   $	��500��65   $	��800��6E   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $	��94* �6    � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $��7* �6   .+�5   
   �� -   5         ��Name$ ListBoxSerie��5      $��1��6(   $	��434��68   $	��174��6H   
�����p�$��2��6o   ��6|   �� *ListeSeriesAffiche+��5      �� 5      .R�5      �� .+�5      �� $��60��6=   $��60��6I   ��6    �� *	Miniature+6I   �� 5       �� TextAlignment$ Center=�69   ��6$   �� *Nom+69   5      5      5      �� 5!   
   $��2��6   $��1��6$   .��5"      ��  � DataContext 6   ��  �� ElementName$ ListBoxSerie�� �� Path$ SelectedItem� �� UpdateSourceTrigger$ PropertyChanged=�.��5#      #   presentation_Serie.UC_Details  -   5        	  Name$	 
uC_Details��5#   #   $	��847��67   5$      5%      �� 5'   
   $��1��6   $��1��6&   $��5,1,4,1q�66   .+�5*      ]� $��42��6   .+�5+      �� -   5        
 ��Name$
 RechercheSerie��5+   &   $	��123��6   $��	10,10,0,0q�6>   $��Recherche ...��6Q   $
��Left=�6f   $��25��6|   $
��Left=�6�   $	��Top=�6�   �� 5,      -   5         ��Name$ LanceRecherche��5,   B   $��25��6   $��25��6%   $��25��63   $��0,10,3,0q�6l   $��Right=�6~   $
��Left=�6�   $	��Top=�6�   .��5-      �� $1��+/Images;Component/Image_Technique/loupe.png��6   5.      5/      �� 50      $��Catégorie:��6   $
��Wrap=�6*   
������ $	��156��6W   $
��Left=�6c   $��	10,5,0,-5q�6~   $��Center=�6�   � 51      $��48��6   .+�52      �� -   5         ��Name$ 	ComboBox1��52      $��10,10,10,10q�6J   .@�53      ��  �� 
IsSelected$
 True��6#   $
��Tous��65   �� 54      $��SF et Action��6#   �� 55      $��Sitcom��6#   �� 56      $��Manga��6#   �� 57      $��Animé��6#   �� 58      $��Thriller��6#   �� 59      $��Documentaire��6#   5:      5;      5=      �� 5>   
   $
��Wrap=�6   $��22(�6,   $�� Sériepédia��5?      $��0,23,0,0q�6)   $��Center=�6;   $	��108��6X   $	��Top=�6d   $��29��6|   5@      �� 5A   
   -   5        $ 	FenetreCo��5A   )   $��
20,20,0,54q�6<   $��31��6P   $��31��6^   $
��Left=�6m   $	��Top=�6�   $��31��6�   .��5B      �� $0��*/Images;Component/Image_Technique/user.png��6   5C      �� 5E   
   -   5        $ FenetreDeco��5E   &   $��
20,58,0,21q�6;   $��31��6O   $��31��6]   $
��Left=�6l   $	��Top=�6�   $��31��6�   .��5F      �� $2��,/Images;Component/Image_Technique/logout.png��6   $��29��6J   5G      �� 5I   
   -   5        $ Retour��5I   *   $��
0,20,20,54q�6:   $��31��6N   $��31��6]   $��Right=�6k   $	��Top=�6�   $��31��6�   .��5J      �� $2��,/Images;Component/Image_Technique/retour.png��6   5K      �� 5M   
   
���   �$��1q�6%   $��1��69   $��2��6M   5O      �� 5P   
   
���   �$��1q�6%   $��1��69   $��1��6M   �� 5Q   
   
���   �$��1q�6%   $��1��69   $��2��6J   �� 5R   
   
���   �$��1q�6%   $��1��69   $��2��6I   5T      5U      