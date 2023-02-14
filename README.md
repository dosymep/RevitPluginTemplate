# Установка шаблона

### Rider:
1. Вызовите диалог создания нового проекта *"File->New..."*.
1. Вызовите команду *"More Templates"*.
1. Вызовите команду *"Install Template..."*.
1. Выберите папку данного шаблона.

### Visual Studio:
1. Скопируйте zip папку по следующему пути  
   *"%userprofile%\Documents\Visual Studio {version}\Templates\ProjectTemplates\Visual C#"*

# Создание проекта

1. Зайдите в файл проекта (F4: Rider, Double Click: Visual Studio).
1. Замените текст на содержимое проекта "RevitPlugins".

### Если не используете DevExpress:
1. Удалите из файла проекта импорт свойств DevExpress.
1. Замените родительский класс в MainView на PlatformWindow.  