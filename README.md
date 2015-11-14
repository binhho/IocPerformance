Ioc Performance
===============

Source code of my performance comparison of the most popular .NET IoC containers:  
[www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison](http://www.palmmedia.de/Blog/2011/8/30/ioc-container-benchmark-performance-comparison)

Author: Daniel Palme  
Blog: [www.palmmedia.de](http://www.palmmedia.de)  
Twitter: [@danielpalme](http://twitter.com/danielpalme)  

Results
-------
### Explantions
**First value**: Time of single-threaded execution in [ms]  
**Second value**: Time of multi-threaded execution in [ms]  
**_*_**: Benchmark was stopped after 3 minutes and result is extrapolated.  
**OoM**: Benchmark was stopped after an *OutOfMemoryException* was thrown.  
**Error**: Benchmark was stopped after an *Exception* was thrown.  
### Basic Features
|**Container**|**Singleton**|**Transient**|**Combined**|**Complex**|
|:------------|------------:|------------:|-----------:|----------:|
|**No**|66<br/>52|76<br/>61|87<br/>82|98<br/>77|
|**[Autofac 3.5.2](https://github.com/autofac/Autofac)**|771<br/>475|1898<br/>1111|5026<br/>2899|14411<br/>8659|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|505<br/>277|608<br/>331|1808<br/>965|8351<br/>4330|
|**[Catel 4.1.0](http://www.catelproject.com)**|271<br/>300|4012<br/>4258|9893<br/>10077|23585<br/>24319|
|**[DryIoc 1.4.1](https://bitbucket.org/dadhi/dryioc)**|**33**<br/>**36**|**39**<br/>48|**56**<br/>72|92<br/>73|
|**[Dynamo 3.0.2.0](http://martinf.github.io/Dynamo.IoC)**|74<br/>57|94<br/>71|182<br/>130|554<br/>305|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|74<br/>57|126<br/>94|258<br/>160|585<br/>321|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|119<br/>85|143<br/>99|383<br/>233|1095<br/>588|
|**[Grace 2.4.2](https://github.com/ipjohnson/Grace)**|155<br/>108|292<br/>177|749<br/>452|2195<br/>1276|
|**[Griffin 1.1.2](https://github.com/jgauffin/griffin.container)**|295<br/>171|293<br/>199|832<br/>480|2172<br/>1102|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|61<br/>57|75<br/>66|80<br/>88|128<br/>96|
|**[Hiro 1.0.4.41795](https://github.com/philiplaureano/Hiro)**|186<br/>116|181<br/>117|221<br/>136|262<br/>166|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|77<br/>60|116<br/>87|143<br/>114|217<br/>129|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|161<br/>142|2644<br/>1423|29038<br/>31527|165421<br/>164791|
|**[LightInject 3.0.2.7](https://github.com/seesharper/LightInject)**|45<br/>41|44<br/>**47**|61<br/>**71**|**80**<br/>**65**|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|3798<br/>2131|21163<br/>12545|54491<br/>30876|145510<br/>81235|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|373<br/>279|468<br/>255|1129<br/>625|3629<br/>1814|
|**[Mef 4.0.0.0](https://mef.codeplex.com)**|26858<br/>13901|40801<br/>22582|68843<br/>47387|138332<br/>140827|
|**[Mef2 1.0.30.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|209<br/>131|217<br/>142|292<br/>183|525<br/>299|
|**[MicroSliver 2.1.6.0](https://microsliver.codeplex.com)**|192<br/>239|688<br/>428|2412<br/>1320|7235<br/>4849|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|571<br/>372|963<br/>637|2650<br/>1768|9716<br/>7725|
|**[Munq 3.1.6](http://munq.codeplex.com)**|100<br/>82|169<br/>106|577<br/>310|1930<br/>993|
|**[Ninject 3.2.2.0](http://ninject.org)**|5761<br/>3351|22146<br/>12202|59242<br/>35560|169223<br/>94067|
|**[Petite 0.3.2](https://github.com/andlju/Petite)**|4504<br/>2424|4558<br/>2395|5347<br/>2836|5873<br/>3125|
|**[QuickInject 1.0.0.12](https://github.com/isabgol/QuickInject)**|116<br/>110|119<br/>92|187<br/>161|417<br/>439|
|**[SimpleInjector 3.0.0](https://simpleinjector.org)**|54<br/>47|88<br/>66|110<br/>92|143<br/>103|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|908<br/>646|12124<br/>8340|33679<br/>21394|90920<br/>52087|
|**[StructureMap 3.1.6.186](http://structuremap.net/structuremap)**|2166<br/>1942|1982<br/>1893|6367<br/>6209|15651<br/>14801|
|**[StyleMVVM 3.1.5](https://stylemvvm.codeplex.com)**|430<br/>250|479<br/>277|838<br/>458|1656<br/>996|
|**[TinyIoC 1.3](https://github.com/grumpydev/TinyIoC)**|403<br/>347|1636<br/>1007|6815<br/>4728|28887<br/>19155|
|**[Unity 3.5.1404.0](http://msdn.microsoft.com/unity)**|2585<br/>1492|4108<br/>2127|10720<br/>5752|30797<br/>16312|
|**[Windsor 3.3.0](http://castleproject.org)**|432<br/>287|1969<br/>1082|6549<br/>3447|20122<br/>11654|
|**[Zenject 3.0](http://zenject.com)**|752<br/>425|2134<br/>1258|5775<br/>3365|16675<br/>9784|
### Advanced Features
|**Container**|**Property**|**Generics**|**IEnumerable**|**Conditional**|**Child Container**|**Interception With Proxy**|
|:------------|-----------:|-----------:|--------------:|--------------:|------------------:|--------------------------:|
|**No**|110<br/>82|84<br/>73|265<br/>170|99<br/>64|568<br/>327|78<br/>63|
|**[Autofac 3.5.2](https://github.com/autofac/Autofac)**|30051<br/>17195|4095<br/>2345|12929<br/>7212|<br/>|81475<br/>43047|34087<br/>17943|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|10784<br/>5473|<br/>|7204<br/>3919|<br/>|<br/>|<br/>|
|**[Catel 4.1.0](http://www.catelproject.com)**|<br/>|9743<br/>10321|<br/>|<br/>|<br/>|4044<br/>4182|
|**[DryIoc 1.4.1](https://bitbucket.org/dadhi/dryioc)**|103<br/>78|51<br/>59|296<br/>178|52<br/>51|<br/>|<br/>|
|**[Dynamo 3.0.2.0](http://martinf.github.io/Dynamo.IoC)**|757<br/>425|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|1111<br/>618|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Grace 2.4.2](https://github.com/ipjohnson/Grace)**|2258<br/>1182|667<br/>375|2473<br/>1390|793<br/>432|14276<br/>**6947**|7236<br/>3774|
|**[Griffin 1.1.2](https://github.com/jgauffin/griffin.container)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|1068<br/>600|<br/>|1957<br/>1051|<br/>|<br/>|**885**<br/>**514**|
|**[Hiro 1.0.4.41795](https://github.com/philiplaureano/Hiro)**|3100<br/>1870|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|372<br/>229|155<br/>112|<br/>|<br/>|<br/>|<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|2376<br/>1557|18497<br/>13889|45872<br/>25262|<br/>|<br/>|<br/>|
|**[LightInject 3.0.2.7](https://github.com/seesharper/LightInject)**|**93**<br/>**70**|**41**<br/>**57**|**284**<br/>**168**|**50**<br/>**50**|<br/>|1303<br/>719|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|5000<br/>2271|847<br/>473|4114<br/>2057|955<br/>568|<br/>|7693<br/>4288|
|**[Mef 4.0.0.0](https://mef.codeplex.com)**|148646<br/>150247|151187<br/>107432|107992<br/>110329|<br/>|<br/>|<br/>|
|**[Mef2 1.0.30.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|1176<br/>655|255<br/>164|1438<br/>762|<br/>|<br/>|<br/>|
|**[MicroSliver 2.1.6.0](https://microsliver.codeplex.com)**|<br/>|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|13684<br/>7821|65666<br/>67814|7442<br/>8525|2253<br/>1408|OoM<br/>Error|OoM<br/>Error|
|**[Munq 3.1.6](http://munq.codeplex.com)**|1544<br/>832|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|144213<br/>79700|59694<br/>33047|135724<br/>79580|45917<br/>26569|43260200*<br/>38268494*|31902<br/>18691|
|**[Petite 0.3.2](https://github.com/andlju/Petite)**|7016<br/>3752|<br/>|<br/>|<br/>|<br/>|<br/>|
|**[QuickInject 1.0.0.12](https://github.com/isabgol/QuickInject)**|122<br/>95|<br/>|<br/>|<br/>|855298*<br/>454463*|<br/>|
|**[SimpleInjector 3.0.0](https://simpleinjector.org)**|216<br/>138|96<br/>79|811<br/>456|92<br/>71|<br/>|6768<br/>3763|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|65484<br/>42190|<br/>|<br/>|<br/>|<br/>|56499<br/>41713|
|**[StructureMap 3.1.6.186](http://structuremap.net/structuremap)**|15759<br/>14467|5078<br/>4665|13458<br/>11340|<br/>|3080711*<br/>1640566*|11217<br/>6323|
|**[StyleMVVM 3.1.5](https://stylemvvm.codeplex.com)**|1992<br/>1105|1230<br/>679|3251<br/>1862|1344<br/>727|<br/>|<br/>|
|**[TinyIoC 1.3](https://github.com/grumpydev/TinyIoC)**|4583<br/>4042|<br/>|<br/>|<br/>|**12650**<br/>7300|<br/>|
|**[Unity 3.5.1404.0](http://msdn.microsoft.com/unity)**|31292<br/>17421|<br/>|50834<br/>28129|<br/>|38246<br/>21279|109096<br/>56975|
|**[Windsor 3.3.0](http://castleproject.org)**|39283<br/>21756|19112<br/>11141|19028<br/>11112|<br/>|263021*<br/>Error|17337<br/>9570|
|**[Zenject 3.0](http://zenject.com)**|2220<br/>1294|<br/>|<br/>|4904<br/>2910|14641<br/>8563|<br/>|
### Prepare
|**Container**|**Prepare And Register**|**Prepare And Register And Simple Resolve**|
|:------------|-----------------------:|------------------------------------------:|
|**No**|2<br/>|2<br/>|
|**[Autofac 3.5.2](https://github.com/autofac/Autofac)**|361<br/>|392<br/>|
|**[Caliburn.Micro 1.5.2](https://github.com/Caliburn-Micro/Caliburn.Micro)**|59<br/>|64<br/>|
|**[Catel 4.1.0](http://www.catelproject.com)**|6314<br/>|6760<br/>|
|**[DryIoc 1.4.1](https://bitbucket.org/dadhi/dryioc)**|36<br/>|14550<br/>|
|**[Dynamo 3.0.2.0](http://martinf.github.io/Dynamo.IoC)**|16291<br/>|16305<br/>|
|**[fFastInjector 1.0.1](https://ffastinjector.codeplex.com)**|6798<br/>|6864<br/>|
|**[Funq 1.0.0.0](https://funq.codeplex.com)**|**6**<br/>|**7**<br/>|
|**[Grace 2.4.2](https://github.com/ipjohnson/Grace)**|103203<br/>|121912<br/>|
|**[Griffin 1.1.2](https://github.com/jgauffin/griffin.container)**|9737<br/>|9798<br/>|
|**[HaveBox 2.0.0](https://bitbucket.org/Have/havebox)**|66709<br/>|65332<br/>|
|**[Hiro 1.0.4.41795](https://github.com/philiplaureano/Hiro)**|222790*<br/>|230882*<br/>|
|**[IfInjector 0.8.1](https://github.com/iamahern/IfInjector)**|1791<br/>|2527<br/>|
|**[LightCore 1.5.1](http://www.lightcore.ch)**|183<br/>|198<br/>|
|**[LightInject 3.0.2.7](https://github.com/seesharper/LightInject)**|236<br/>|814<br/>|
|**[LinFu 2.3.0.41559](https://github.com/philiplaureano/LinFu)**|103<br/>|372<br/>|
|**[Maestro 1.5.4](https://github.com/JonasSamuelsson/Maestro)**|186<br/>|793<br/>|
|**[Mef 4.0.0.0](https://mef.codeplex.com)**|12<br/>|2527<br/>|
|**[Mef2 1.0.30.0](https://blogs.msdn.com/b/bclteam/p/composition.aspx)**|6008<br/>|7309<br/>|
|**[MicroSliver 2.1.6.0](https://microsliver.codeplex.com)**|10<br/>|14<br/>|
|**[Mugen 3.5.1](http://mugeninjection.codeplex.com)**|405<br/>|1777<br/>|
|**[Munq 3.1.6](http://munq.codeplex.com)**|10770<br/>|10007<br/>|
|**[Ninject 3.2.2.0](http://ninject.org)**|128419<br/>|124612<br/>|
|**[Petite 0.3.2](https://github.com/andlju/Petite)**|12<br/>|35<br/>|
|**[QuickInject 1.0.0.12](https://github.com/isabgol/QuickInject)**|42<br/>|1527<br/>|
|**[SimpleInjector 3.0.0](https://simpleinjector.org)**|354<br/>|1235<br/>|
|**[Spring.NET 2.0.1](http://www.springframework.net/)**|25439<br/>|25219<br/>|
|**[StructureMap 3.1.6.186](http://structuremap.net/structuremap)**|1030<br/>|7165<br/>|
|**[StyleMVVM 3.1.5](https://stylemvvm.codeplex.com)**|72820<br/>|70967<br/>|
|**[TinyIoC 1.3](https://github.com/grumpydev/TinyIoC)**|56<br/>|61<br/>|
|**[Unity 3.5.1404.0](http://msdn.microsoft.com/unity)**|623<br/>|2129<br/>|
|**[Windsor 3.3.0](http://castleproject.org)**|3628<br/>|3632<br/>|
|**[Zenject 3.0](http://zenject.com)**|27<br/>|38<br/>|
### Charts
![Basic features](http://www.palmmedia.de/content/blogimages/5225c515-2f25-498f-84fe-6c6e931d2042.png)
![Advanced features](http://www.palmmedia.de/content/blogimages/e0401485-20c6-462e-b5d4-c9cf854e6bee.png)
![Prepare](http://www.palmmedia.de/content/blogimages/67b056a5-9da8-40b4-9ae6-0c838cdac180.png)
