   M S B A M L   `   `   `  ����M  Ipresentation-Serie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:presentation_Seriepresentation_Serie  5      #    presentation_Serie.UC_Details   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:presentation_Serie     5      .��5
      � 
�������$��
0,0,0,-615q�6"     � RowDefinitions  5   
   �� 5      $��24 �6   5      �� 5      $��96 �6   .+�5   
   �� $��
  Synopsis��6   $��	0,0,536,0q�6&   $��0��69   �� 5   
   $��1��6   .��5      �� 2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6h   $��1��6H   $��	10,0,10,0q�6U   $
��Wrap=�6h   ��6.   �� *
Synopsis+6h   5      �� 5   
   $��Bande Annonce��6   $��1��6)   $��
0,96,0,-24q�66   �� 5   
   $��  Disponibilités :��6   $��0,370,500,-298q�6.   $��1��6F   �� 5   
   $��89,370,0,-298q�64   $��1��6K   ��6   �� *Disponibilite+6K   �� 5   
   $��  Commentaires :��6   $��0,399,500,-327q�6,   $��1��6D   �� 5   
   -   5         ��Name$ EcrireCommentaire��5   L   $��0,428,0,-435q�6   $��1��6(   
�������
���   �.��6{   Entrez votre avis ...6�   �� 5   
   -   5         ��Name$ PosterCommentaire��5   ]   $��14,536,0,-461q�6   $��1��6(   $��Envoyer��65   
�������$
��Left=�6�   $��75��6�   �� 5   
   $��0,574,0,-871q�6   $��1��6(   
�������
������ ��6f   �� *ListeCommentaires+��5      �� 5       .R�5!      �� $
��Wrap=�66   ��6    �� *Avis+66   5"      5$      �� 5&   
   
���   �$��1q�6%   $��0,96,0,-269q�69   $��1��6N   ._�5'      � $��-1,0,0,0q�6   .+�5(      r� -   5         r�Name$ MediaElement��5(   �   $
��Left=�6   $	��240��6:   $	��Top=�6G   $	��499��6_    r� LoadedBehavior$
 Play=�6�   $y�Visible=�6�   $��
115,10,0,0q�6�    r� Source 6k   �� *BandeAnnonce+6�   5)      5*      �� 5+   
   
���   �$��1q�6%   $��2��69   5,      5-      