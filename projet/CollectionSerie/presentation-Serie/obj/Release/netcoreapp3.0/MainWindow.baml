   M S B A M L   `   `   `  ���� M  Ipresentation-Serie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:presentation_Seriepresentation_Serie  #    presentation_Serie.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:presentation_Serie       � Title$  
MainWindow��$	��500��$	��800��$	��500��$	��800��.���  � RowDefinitions �� $	��27* ��� $	��94* � � ColumnDefinitions �� $	��25* ��� $��7* �.+��� -    ��Name$ ListBoxSerie��$��1��$	��434��$	��174��
�����p�$��2������ *ListeSeriesAffiche+���� .R��� .+��� $��60��$��60������ *	Miniature+��  �� TextAlignment$ Center=����� *Nom+�� $��2��$��1��.����  � DataContext ��  �� ElementName$ ListBoxSerie�� �� Path$ SelectedItem� �� UpdateSourceTrigger$ PropertyChanged=�.��#   presentation_Serie.UC_Details  -   	  Name$	 
uC_Details��$	��847���� $��1��$��1��$��5,1,4,1q�.+�]� $��42��.+��� -   
 ��Name$
 RechercheSerie��$	��123��$��	10,10,0,0q�$��Recherche ...��$
��Left=�$��25��$
��Left=�$	��Top=��� -    ��Name$ LanceRecherche��$��25��$��25��$��25��$��0,10,3,0q�$��Right=�$
��Left=�$	��Top=�.���� $1��+/Images;Component/Image_Technique/loupe.png���� $��Catégorie:��$
��Wrap=�
������ $	��156��$
��Left=�$��	10,5,0,-5q�$��Center=�� $��48��.+��� -    ��Name$ 	ComboBox1��$��10,10,10,10q�.@���  �� 
IsSelected$
 True��$
��Tous���� $��SF et Action���� $��Sitcom���� $��Manga���� $��Animé���� $��Thriller���� $��Documentaire���� $
��Wrap=�$��22(�$�� Sériepédia��$��0,23,0,0q�$��Center=�$	��108��$	��Top=�$��29���� -   $ 	FenetreCo��$��
20,20,0,54q�$��31��$��31��$
��Left=�$	��Top=�$��31��.���� $0��*/Images;Component/Image_Technique/user.png���� -   $ FenetreDeco��$��
20,58,0,21q�$��31��$��31��$
��Left=�$	��Top=�$��31��.���� $2��,/Images;Component/Image_Technique/logout.png��$��29���� -   $ Retour��$��
0,20,20,54q�$��31��$��31��$��Right=�$	��Top=�$��31��.���� $2��,/Images;Component/Image_Technique/retour.png���� 
���   �$��1q�$��1��$��2���� 
���   �$��1q�$��1��$��1���� 
���   �$��1q�$��1��$��2���� 
���   �$��1q�$��1��$��2��