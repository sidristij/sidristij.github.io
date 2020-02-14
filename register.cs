<!DOCTYPE html>
<html><head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <title>CLRium #7: Практика работы с многопоточным кодом</title>
    <meta charset="utf-8">
    <meta property="og:image" content="img/thumbnail.png" />
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/media.css">
    <link rel="stylesheet" href="css/all.css">
    <link rel="shortcut icon" href="/img/favicon.ico" type="image/x-icon">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <header class="header fixed">
        <a href="/">
            <img class="conflogo" src="img/logo-w-noindex.svg"/> 
        </a>
        <div class="menu">
            <div><a href="index.html">О конференции</a></div>
            <div><a href="mentor.html">Ментор</a></div>
            <div><a href="practice.html">Практика</a></div>
            <div><a href="matrix.html">Доклады</a></div>
            <a href="register.html" class="register_button">РЕГИСТРАЦИЯ</a>
        </div>

        <!-- mobile-menu -->

        <div class="hamburger-menu">
            <input id="menu__toggle" type="checkbox" />
            <label class="menu__btn" for="menu__toggle">
              <span></span>
            </label>
        
            <ul class="menu__box">
                <li><a class="menu__item" href="index.html">О семинаре</a></li>
                <li><a class="menu__item" href="mentor.html">Ментор</a></li>
                <li><a class="menu__item" href="matrix.html">Доклады</a></li>
                <li><a class="menu__item" href="practice.html">Практика</a></li>
                <li><a class="menu__item" href="register.html">Регистрация</a></li>
            </ul>
        </div>
    </header>
    <section class="mentor_heading">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="mentor_heading_text">
                        <h1>Регистрация</h1>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="about mentor_about contents_area">
        <div class="container">
            <div class="row about_wrap">
                <div class="col-12">
                    <div class="breadcrumbs_menu">
                        <div class="inactive_item">О семинаре</div>
                        <div class="inactive_item">→</div>
                        <div class="active_item">Регистрация</div>
                    </div>
                    <div>
                        <h2>Варианты участия</h2>
                        <div class="container register_variants">
                            <div class="row ticket-table">
                                <div class="col-lg-3 col-sm-6 col-12 ticket-col">
                                    <div class="ticket-card">
                                        <a class="ticket-link" href="./reg/petersburg.html">
                                            <h3>Петербург</h3>
                                            <p class="ticket-when">
                                                <strong>18 апреля 2020</strong><br> 
                                                10<sup>00</sup> - 20<sup>00</sup>
                                            </p>
                                            <p class="ticket-descr">
                                                Посещение семинара с оплатой физ. и юр. лицами. Также может включать в себя 
                                                проверку домашних заданий. Количество слотов с проверкой домашних заданий оганичено.
                                            </p>
                                            <p class="ticket-buy"> 
                                                Купить
                                            </p>
                                        </a>
                                    </div>
                                </div>
                                <div class="col-lg-3 col-sm-6 col-12 ticket-col">
                                    <div class="ticket-card">
                                        <a class="ticket-link" href="./reg/moscow.html">
                                            <h3>Москва</h3>
                                            <p class="ticket-when">
                                                <strong>16 мая 2020</strong><br> 
                                                10<sup>00</sup> - 20<sup>00</sup>
                                            </p>
                                            <p class="ticket-descr">
                                                Посещение семинара с оплатой физ. и юр. лицами. Также может включать в себя 
                                                проверку домашних заданий. Количество слотов с проверкой домашних заданий оганичено.
                                            </p>
                                            <p class="ticket-buy"> 
                                                Купить
                                            </p>   
                                        </a>                 
                                    </div>
                                </div>
                                <div class="col-lg-3 col-sm-6 col-12 ticket-col">
                                    <div class="ticket-card">
                                        <a class="ticket-link" href="./reg/mentor.html">
                                            <h3>Ментор</h3>
                                            <p class="ticket-when">
                                                <strong>с 16 мая 2020</strong><br> 
                                                по договорённости
                                            </p>
                                            <p class="ticket-descr">
                                                Поговорив с ментором, вы узнаете свои ошибки, раскроете выбранную тему досконально, 
                                                что даст вам большую уверенность как на текущем проекте, так и при смене своей 
                                                работы<span class="d-none d-xl-inline"> на новую</span>.
                                            </p>
                                            <p class="ticket-buy"> 
                                                Купить
                                            </p>
                                        </div>
                                    </a>
                                </div>
                                <div class="col-lg-3 col-sm-6 col-12 ticket-col">
                                    <div class="ticket-card">
                                        <a class="ticket-link" href="./reg/videos_only.html">
                                            <h3>Видеозаписи</h3>
                                            <p class="ticket-when">
                                                <strong>с 16 мая 2020</strong><br> 
                                                в любое время :)
                                            </p>
                                            <p class="ticket-descr">
                                                Прослушивание семинара с оплатой физ. и юр. лицами. Также может включать в себя 
                                                проверку домашних заданий. Количество слотов, включающих проверку домашних заданий оганичено.
                                            </p>
                                            <p class="ticket-buy"> 
                                                Купить
                                            </p>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div>
                        <h2>Немного подробностей</h2>
                        <h3>Что входит в семинар</h3>

                        <p>
                            Входной билет на семинар включает в себя сам семинар, записи докладов и кофе-брейки. 
                            Программа семинаров для Москвы и Санкт-Петербурга при этом не отличается.
                        </p>
                        <p>
                            Также можно приобрести только видеозаписи без посещения семинара. Для этого необходимо зарегистрироваться на "Видеозаписи семинара"
                        </p>

                        <h3>Собеседования с ментором</h3>

                        <p>При наличии свободных мест есть возможность провести собеседование с личным ментором. Подробнее об этом можно прочитать в <a href="mentor.html">соответствующем разделе сайта</a>.</p>
            
                        <h3>Запись семинара</h3>

                        <p>Запись докладов будет доступна всем кто купил соответствующий тип билета - после семинара.</p>
                        <p>Мы решили не делать трансляцию, т.к. она забирает много наших ресурсов, а качество трансляции зависит от слишком многих факторов чтобы при той же цене на билеты иметь возможность их контролировать.</p>
                        
                        <h3>Приобретение билета работодателем</h3>

                        <p>Если Вы хотите попытать счастья и посетить семинар бесплатно для себя, вы можете скоординироваться с людьми из Вашей компании и написать коллективное письмо своему менеджеру.
                        Оплата юр. лицами производится через бронирование билетов и указанием типа оплаты "Выставить счёт".</p>
                        
                    </div>
                </div>
            </div>
        </div>
    </section>

    <footer >
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="footer_wrap">
                        <img src="img/logo-w-noindex.svg">
                        <p>
                            <a class="footer-link" target="_blank" href="mailto:sidristij@clrium.ru"><i class="far fa-envelope" aria-hidden="true"></i></a>
                            <a class="footer-link" target="_blank" href="https://vk.com/clrium"><i class="fab fa-vk" aria-hidden="true"></i></a>
                            <a class="footer-link" target="_blank" href="https://youtube.com/clrium"><i class="fab fa-youtube" aria-hidden="true"></i></a>
                            <a class="footer-link" target="_blank" href="https://github.com/clrium"><i class="fab fa-github" aria-hidden="true"></i></a>
                            <a class="footer-link" target="_blank" href="skype:stanislav.sidristyi"><i class="fab fa-skype" aria-hidden="true"></i></a>
                            <a class="footer-link" target="_blank" href="https://t.me/clrium_group"><i class="fab fa-telegram" aria-hidden="true"></i></a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <script src="js/index.js"></script>

    <!-- Yandex.Metrika counter -->
    <script type="text/javascript" >
        (function(m,e,t,r,i,k,a){m[i]=m[i]||function(){(m[i].a=m[i].a||[]).push(arguments)};
        m[i].l=1*new Date();k=e.createElement(t),a=e.getElementsByTagName(t)[0],k.async=1,k.src=r,a.parentNode.insertBefore(k,a)})
        (window, document, "script", "https://mc.yandex.ru/metrika/tag.js", "ym");
        ym(25102367, "init", { clickmap:true, trackLinks:true, accurateTrackBounce:true, webvisor:true });
    </script>
    <noscript><div><img src="https://mc.yandex.ru/watch/25102367" style="position:absolute; left:-9999px;" alt="" /></div></noscript>
    <!-- /Yandex.Metrika counter -->
</body>
</html>