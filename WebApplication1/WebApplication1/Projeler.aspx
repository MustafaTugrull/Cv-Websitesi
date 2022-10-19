﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projeler.aspx.cs" Inherits="WebApplication1.Projeler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>MUSTAFA TUĞRUL CV WEB SİTESİ </title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="manifest" href="site.webmanifest">
    <link rel="shortcut icon" type="image/x-icon" href="assets/img/favicon.ico">

    <!-- CSS here -->
    <link rel="stylesheet" href="assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="assets/css/owl.carousel.min.css">
    <link rel="stylesheet" href="assets/css/slicknav.css">
    <link rel="stylesheet" href="assets/css/animate.min.css">
    <link rel="stylesheet" href="assets/css/magnific-popup.css">
    <link rel="stylesheet" href="assets/css/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/css/themify-icons.css">
    <link rel="stylesheet" href="assets/css/slick.css">
    <link rel="stylesheet" href="assets/css/nice-select.css">
    <link rel="stylesheet" href="assets/css/style.css">
</head>
<body class="body-bg">
    <form id="form1" runat="server">
        <div id="preloader-active">
            <div class="preloader d-flex align-items-center justify-content-center">
                <div class="preloader-inner position-relative">
                    <div class="preloader-circle"></div>
                    <div class="preloader-img pere-text">
                        <img src="assets/img/logo/logo.png" alt="">
                    </div>
                </div>
            </div>
        </div>
        <!-- Preloader Start -->
        <header>
            <!-- Header Start -->
            <div class="header-area header-sticky">
                <div class="header-wrapper  d-flex flex-wrap align-items-center justify-content-between">
                    <!-- Logo -->
                    <div class="logo">
                        <a href="Default.aspx">
                            <img src="assets/img/logo/logo.png" alt=""></a>
                    </div>
                    <!-- Main-menu -->
                    <div class="main-menu d-none d-lg-block">
                        <nav>
                            <ul id="navigation">
                                <li><a href="Default.aspx">Anasayfa</a></li>
                                <li><a href="Biyografi.aspx">Biyografi</a></li>
                                <li><a href="Projeler.aspx">Projeler</a></li>
                                <li><a href="CV.aspx">CV</a></li>
                                <li><a href="Hakkında.aspx">Hakkında</a></li>
                                <li><a href="İletişim.aspx">İletişim</a></li>
                            </ul>
                        </nav>
                    </div>
                    <!-- Header-btn -->
                    <div class="d-none d-xl-block">
                        <a class="btn btn2" href="assets/files/CV.pdf">CV İNDİR</a>
                    </div>
                    <!-- Mobile Menu -->
                    <div class="col-12">
                        <div class="mobile_menu d-block d-lg-none"></div>
                    </div>
                </div>
            </div>
            <!-- Header End -->
        </header>
        <main>
            <!-- slider Area Start-->
            <div class="slider-area ">
                <!-- Mobile Menu -->
                <div class="single-slider slider-height2 d-flex align-items-center" data-background="assets/img/hero/gallery.jpg">
                    <div class="container">
                        <div class="row">
                            <div class="col-xl-12">
                                <div class="hero-cap">
                                    <h2>PROJELER</h2>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- slider Area End-->
            <!-- Clients Offers Start -->
            <div class="clients-area section-padding03">
                <div class="container">
                    <!-- Section Tittle -->
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="section-tittle text-center mb-100">
                                <span class=" wow fadeInUp" data-wow-delay=".2s">
                                    <asp:Literal ID="Literal5" runat="server"></asp:Literal>
                                </span>
                                <h2 class=" wow fadeInUp" data-wow-delay=".3s">
                                    <asp:Literal ID="Literal6" runat="server"></asp:Literal>
                                </h2>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".2s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers1.jpg" alt="">
                                </div>
                                 <div class="offers-cap">
                                    <span></span>
                                    <h3><a>
                                            <asp:Literal ID="Literal7" runat="server"></asp:Literal>
                                        </a></h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".4s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers2.jpg" alt="">
                                </div>
                                <div class="offers-cap">
                                    <span></span>
                                    <h3><a>
                                            <asp:Literal ID="Literal8" runat="server"></asp:Literal>

                                        </a></h3>
                                    <p>  </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".6s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers3.jpg" alt="">
                                </div>
                                <div class="offers-cap">
                                    <span></span>
                                    <h3><a>
                                            <asp:Literal ID="Literal9" runat="server"></asp:Literal>

                                        </a></h3>
                                    <p>  </p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".2s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers1.jpg" alt="">
                                </div>
                                <div class="offers-cap">
                                    <span></span>
                                    <h3><a>Blackjack Oyunu</a></h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".4s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers2.jpg" alt="">
                                </div>
                                <div class="offers-cap">
                                    <span></span>
                                    <h3><a>Tic Tac Toe Oyunu</a></h3>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="single-offers mb-50 wow fadeInUp" data-wow-delay=".6s">
                                <div class="offers-img">
                                    <img src="assets/img/gallery/offers3.jpg" alt="">
                                </div>
                                <div class="offers-cap">
                                    <span></span>
                                    <h3><a>Kütüphane Yönetim Sistemi</a></h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Clients Offers End -->
        </main>
        <footer>
            <div class="footer-area fix">
                <!-- Footer Caption -->
                <div class="footer-caption wow fadeInRight" data-wow-delay=".6s">
                    <div class="footer-tittle">
                        <h3>
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            <br>
                            <asp:Literal ID="Literal2" runat="server"></asp:Literal>

                        </h3>
                    </div>
                    <div class="footer-menu ">
                        <div class="single-menu">
                            <div class="single-menu1">
                                <div class="single-footer-caption mb-50">
                                    <div class="footer-tittle">
                                        <h4>İletişim</h4>
                                        <div class="footer-pera">
                                            <p>
                                                <asp:Literal ID="Literal3" runat="server"></asp:Literal>
                                                <br \ />
                                                <asp:Literal ID="Literal4" runat="server"></asp:Literal>


                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="single-menu2">
                                <div class="single-footer-caption mb-50">
                                    <div class="footer-tittle">
                                        <h4>Linkler</h4>
                                        <ul>
                                            <li><a href="Default.aspx">Anasayfa</a></li>
                                            <li><a href="Hakkında.aspx">Hakkında </a></li>
                                            <li><a href="Biyografi.aspx">Biyografi</a></li>
                                            <li><a href="İletişim.aspx">İletişim</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="single-menu3">
                                <div class="single-footer-caption">
                                    <div class="footer-tittle">
                                        <h4>Takipte Kalın</h4>
                                        <!-- Social -->
                                        <div class="footer-social">
                                            <a href="#"><i class="fab fa-facebook-f"></i></a>
                                            <a href="#"><i class="fab fa-twitter"></i></a>
                                            <a href="#"><i class="fas fa-globe"></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="copyright pt-40">
                        <p>
                            <p>
                                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                                Copyright &copy;<script>document.write(new Date().getFullYear());</script>
                                All rights reserved | This template is made with M.Tuğrul <a  target="_blank">.</a>
                                <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            </p>
                        </p>
                    </div>
                </div>
            </div>
        </footer>

        <!-- JS here -->
        <!-- All JS Custom Plugins Link Here here -->
        <script src="./assets/js/vendor/modernizr-3.5.0.min.js"></script>
        <!-- Jquery, Popper, Bootstrap -->
        <script src="./assets/js/vendor/jquery-1.12.4.min.js"></script>
        <script src="./assets/js/popper.min.js"></script>
        <script src="./assets/js/bootstrap.min.js"></script>
        <!-- Jquery Mobile Menu -->
        <script src="./assets/js/jquery.slicknav.min.js"></script>

        <!-- Jquery Slick , Owl-Carousel Plugins -->
        <script src="./assets/js/owl.carousel.min.js"></script>
        <script src="./assets/js/slick.min.js"></script>
        <!-- One Page, Animated-HeadLin -->
        <script src="./assets/js/wow.min.js"></script>
        <script src="./assets/js/animated.headline.js"></script>
        <script src="./assets/js/jquery.magnific-popup.js"></script>

        <!-- Scrollup, nice-select, sticky -->
        <script src="./assets/js/jquery.scrollUp.min.js"></script>
        <script src="./assets/js/jquery.nice-select.min.js"></script>
        <script src="./assets/js/jquery.sticky.js"></script>

        <!-- contact js -->
        <script src="./assets/js/contact.js"></script>
        <script src="./assets/js/jquery.form.js"></script>
        <script src="./assets/js/jquery.validate.min.js"></script>
        <script src="./assets/js/mail-script.js"></script>
        <script src="./assets/js/jquery.ajaxchimp.min.js"></script>

        <!-- Jquery Plugins, main Jquery -->
        <script src="./assets/js/plugins.js"></script>
        <script src="./assets/js/main.js"></script>
    </form>
</body>
</html>
