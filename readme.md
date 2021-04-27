### 前言
![原代码仓库链接，请点击它，支持原版本](https://github.com/geovens/gInk)
有一天需要在屏幕上标注的软件，然后就发现了该软件十分不错，很适合我。但是该软件有一些小问题，在我的笔记本为125%的dpi放缩，会使图片显示错位，我修复了它。感觉鼠标图标做的不好，删掉了比较别扭的大图标，然后添加了一个笔和橡皮擦的图标。本人是业余爱好者，技艺不精，仅做此修改。（所有修改的代码我全部以注释的形式修改，也可以到原来的仓库下载）。这也是我第一次上传代码到GitHub，如有不合适的地方欢迎指出，见谅。


* 如下是原来代码仓库的说明：


#### Introduction

gInk is an on-screen annotation software under Windows, used to help improving my presentations and demonstrations, and to help working on temperary thoughts which need to be noted beside something on the screen. The features are greatly inspired by another screen annotation software Epic Pen, but even more easy to use. gInk is made with the idea kept in mind that the interface should be as simple as possible and should not distract attention of both the presenter and the audience when used for presentations. Unlike in many other softwares in the same category, you select from pens to draw things instead of changing individual settings of color, transparency and tip width everytime. Each pen is a combination of these attributes and is configurable to your need.

#### Screen Shots

![screenshot](https://raw.githubusercontent.com/geovens/gInk/master/screenshot1.jpg)  
![screenshot](https://raw.githubusercontent.com/geovens/gInk/master/screenshot2.jpg)  

#### Download

https://github.com/geovens/gInk/releases/

#### How to use

Start gInk and an icon will appear in the system tray. Click the icon (or use a hotkey) to start drawing on screen.  
Click the exit button or press ESC to exit drawing.  

#### Features

- Compact and intuitive interface.  
- Inks rendered on dynamic desktops.  
- Stylus with eraser, touch screen and mouse compatible.  
- Click-through mode.  
- Multiple displays support.  
- Pen pressure support.  
- Snapshot support.  
- Hotkey support.    

#### Tips

- There is a known issue for multiple displays of unmatched DPI settings (100%, 125%, 150%, etc.). If you use gInk on a computer with multiple displays of unmatched DPI settings, or you encounter problems such as incorrect snapshot area, being unable to drag toolbar to locations etc., please do the following as a workaround (in Windows 10 version 1903 as an example): right-click gInk.exe, Properties, Compatibility, Change high DPI settings, Enable override high DPI scaling behavior scaling performed by: Application. (do this only for gInk version v1.1.0 and after)
- There are a few hidden options you can tweak in config.ini that are not shown in the options window.
- Many have asked for features to draw lines, arrows, squares, texts etc. I indeed wish to add these features, but currently I haven't found a way to implement them while keeping the UI simple, which I weight more. The good news is that someone else (pubpub-zz) is actively working on a project [ppInk](https://github.com/pubpub-zz/ppInk) which is based on gInk, adding many more functions to it including drawing lines, arrows, squared, texts etc. You could check whether the fork project meets your needs if you want these features.

#### How to contribute translation

gInk supports multiple languages now. Here is how you can contribute translation. Simply create a duplication of the file "en-us.txt" in "bin/lang" folder, rename it and then translate the strings in the file. Check in gInk to make sure your translation shows correctly, and then you can make a pull request to merge your translation to the next version of release for others to use.  


----
gInk  
https://github.com/geovens/gInk  
Weizhi Nai @ 2020  
