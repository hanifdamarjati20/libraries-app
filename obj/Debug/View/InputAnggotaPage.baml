   M S B A M L   `   `   `  ����E  APerpusDong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PerpusDong.ViewPerpusDong.View  5   	   &     PerpusDong.View.InputAnggotaPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PerpusDong.View     5   	     � Title$  InputAnggotaPage��5   	   $	��450��6"   $	��800��6/   
����d�.��5	      � .+�5   
   �� 
�������$��10,122,10,10q�6$   .+�5      �� $��../Image/anggota.png��6    �� Left$ 10��62   
 �� Top$ 77��6C   $	��110��6S   $	��259��6`   �� 5      -   5         ��Name$ lblAnggota2��5      $��Id Anggota : ��6)   $��Medium"�6A   $��86��6U   $	 363��6`   $ 31��6r   �� 5      -   5        $ lblAnggota3��5      $��Nama : ��6)   $��Medium"�6;   $��70��6O   $	 391��6Z   $ 52��6l   �� 5      -   5        $ lblAnggota4��5      $��	Alamat : ��6)   $��Medium"�6=   $��70��6Q   $	 385��6\   $ 98��6n   �� 5      -   5        $ lblAnggota5��5      $��
Telepon : ��6)   $��Medium"�6>   $��70��6R   $	 382��6]   $ 75��6o   �� 5      -   5        $ lblAnggota6��5      $��Jenis Kelamin : ��6)   $��Medium"�6D   $��98��6X   $	 351��6c   $	 121��6u   �� 5      -   5        $ lblAnggota7��5      $��Tanggal Lahir : ��6)   $��Medium"�6D   $	��101��6X   $	 351��6d   $	 172��6v   �� 5      -   5        $ 
lbAnggota8��5      $��Tempat Lahir : ��6(   $��Medium"�6B   $��94��6V   $	 354��6a   $	 144��6s   �� 5      -   5        $ lblAnggota9��5      $��Tanggal Daftar : ��6)   $��Medium"�6E   $	��110��6Y   $	 345��6e   $	 199��6w   (  "System.Windows.Controls.DatePicker  5      -	   5          Name$ dtpTanggalLahir��5      $	 442��62   $	 172��6D   $	��140��6U     5      -
   5        $ dtpTanggalDaftar��5      $	 201��63   $	 442��6D   $	��140��6V   �� 5      -   5         ��Name$ txtIdAnggota��5      $	 442��6,   $ 34��6>   $	��140��6N   
������� J� Opacity$	 0.8Q�6m   �� 5      -   5        $ txtNama��5      $	 442��6'   $ 57��69   $	��140��6I   
�������$	 0.8Q�6h   �� 5      -   5        $ 
txtTelepon��5      $	 442��6*   $ 80��6<   $	��140��6L   
�������$	 0.8Q�6k   �� 5      -   5        $ 	txtAlamat��5      $	 442��6)   $	 103��6;   $	��140��6L   
�������$	 0.8Q�6k   �� 5      -   5        $ 	txtGender��5      $	 442��6)   $	 126��6;   $	��140��6L    J� RenderTransformOrigin$ 0.543,1.389&�6X   
�������$	 0.8Q�6�   �� 5      -   5        $ txtTempatLahir��5      $	 442��6.   $	 149��6@   $	��140��6Q   
�������$	 0.8Q�6p   �� 5      -   5         ��Name$ btnSave��5      $
��Save��6&   
����  �
�������$��Medium"�6Z   $	 487��6n   $	 230��6�   $��45��6�   6�   �� 5       -   5        $ 	btnCancel��5       $��Cancel��6(   
���  ��
�������$��Medium"�6]   $	 537��6q   $	 230��6�   $��45��6�   6�   5!      �� 5"   
   
�������$	 0.7Q�6$   $��	0,0,0,355q�62   .+�5#      �� -   5        $ 
btnKembali��5#      $��50��6)   $��12(�64   
�������$ 10��6U   $ 10��6f   $��44��6v   .��5$      �� $��..\\Image\93634.png��6   $��Center=�65   5%      5&      �� 5'   
   -   5        $ lblAnggota1��5'      $��Anggota��6%   
���   �$��26(�5(      $��Medium"�6   $��Center=�62   $��262,10,262,355q�6O   �� 5)   
   -   5        $ btnDaftarAnggota��5)      $��Daftar Anggota��6+   $��Center=�6D   $��10,102,674,0q�6a   $	��Top=�6w   $	��108��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   �� 5*   
   -   5        $ btnInputAnggota��5*      $��Input Anggota��6*   $��Center=�6B   $��118,102,566,0q�6_   $	��Top=�6v   $	��108��6�   
����  �$��12(�6�   $
��Bold"�6�   
�������6�   5,      5-      