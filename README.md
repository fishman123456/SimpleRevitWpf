# SimpleRevitWpf
Первое окно в Revit
<img width="974" height="740" alt="image" src="https://github.com/user-attachments/assets/0ffb8103-e8bf-4642-8bf1-90f4c864b75a" />
.Net Framework 4.8
1 Создать проект библиотека классов  .Net Framework 4.8
2 Добавить элемент User Control
3 Переименовать User Control (в файле Xaml) в Windows
4 Переименовать User Control (в файле cs) в Windows
5 создать файл манифест

SimplRevitWpf.addin

<?xml version="1.0" encoding="utf-8"?>
<RevitAddIns>
  <AddIn Type="Command">
    <Text>Simple WPF</Text>
    <Description>Простой WPF плагин</Description>
    <Assembly>SimpleRevitWpf.dll</Assembly>
    <AddInId>61E97ECA-A69F-4DE0-BF65-E8010E53F059</AddInId>   // код берем из СРЕДСТВА - СОЗДАТЬ GUID - 4 Формат реестра
    <FullClassName>SimpleRevitWpf.SimpleCommand</FullClassName>
    <Text>Первое окно</Text>
    <VendorId>MyWin</VendorId>
<VendorDescription></VendorDescription>
  </AddIn>
</RevitAddIns>
