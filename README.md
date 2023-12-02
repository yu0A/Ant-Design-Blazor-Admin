![screenshot1](https://github.com/yu0A/Ant-Design-Blazor-Admin/blob/master/Ant-Design-Blazor-Admin/Shared/Logo/logo.png)<br><br>
# Ant Design Blazor Admin
---
这是一套基于Ant Design Blazor的Admin代码。<br>
这套Admin代码集成了Ant Design Blazor组件库，帮助开发者快速开发自己的Admin应用。
---
我最近发现，用Blazor全栈开发WebAPP的速度非常快，甚至比PHP还快。Blazor和PHP的设计思想类似，可以将每一个razor文件看做是一个网页、一个类库或者一个css，或者三者的组合体。推荐用PHP的朋友来试试这套Blazor代码，绝对不会让你们失望。<br><br>
而且，互操作是.NET的一大亮点。Blazor也支持JSInterop和JS代码互操作，所以偏前端的开发者也可以多写JS模块，然后在razor代码里面用JSInterop调JS函数。<br><br>
对于前端开发者而言，Blazor非常适合开发SPA应用。Blazor在发ajax、数据操作和管理组件等场景中非常方便，还支持丰富的组件库，推荐一试。
---
# 安装依赖
安装[.Net 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)<br>.Net 7.0+Blazor的已知bug也不少，如果不追求稳定性的话，那么更建议用.Net 8.0 Preview。<br><br>
在安装.Net之后，在控制台输入<br>
$ dotnet new blazorwasm -o PROJECT-NAME<br>
以创建Blazor模板代码。<br><br>
然后，在控制台输入<br>
$ dotnet add package AntDesign<br>
以安装Ant Design Blazor。<br><br>
然后，在控制台输入<br>
$ dotnet run<br>
以运行或调试Blazor模板代码。<br><br>
然后，在控制台输入<br>
$ dotnet publish -c release -o dist<br>
以构建和部署Blazor模板代码。
---
# 截图
![screenshot1](https://github.com/yu0A/Ant-Design-Blazor-Admin/blob/master/Ant-Design-Blazor-Admin/Client/Screenshots/screenshot1.png)<br><br>
![screenshot2](https://github.com/yu0A/Ant-Design-Blazor-Admin/blob/master/Ant-Design-Blazor-Admin/Client/Screenshots/screenshot2.png)<br><br>
![screenshot3](https://github.com/yu0A/Ant-Design-Blazor-Admin/blob/master/Ant-Design-Blazor-Admin/Client/Screenshots/screenshot3.png)<br><br>
---
# 开源库链接

[ASP .Net Core](https://docs.microsoft.com/aspnet/)<br><br>
[Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)<br><br>
[Ant Design Blazor](https://github.com/ant-design-blazor/ant-design-blazor)
---
# 鸣谢
感谢 [@xiaoMan](https://github.com/message163) 提供的"antb"logo
