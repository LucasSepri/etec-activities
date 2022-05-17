<!DOCTYPE html>
<html lang="pt-br">
<head>
    <!-- WebSite formats -->
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=Loja Virtual, initial-scale=1.0">

    <!-- title WebSite-->
    <title>WebSite Title</title>

    <!-- Icon to WebSite; Favicons  -->  <!-- https://www.favicon-generator.org/ -->
    <link rel="apple-touch-icon" sizes="57x57" href="./assets/images/favicons/apple-icon-57x57.png">
    <link rel="apple-touch-icon" sizes="60x60" href="./assets/images/favicons/apple-icon-60x60.png">
    <link rel="apple-touch-icon" sizes="72x72" href="./assets/images/favicons/apple-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="76x76" href="./assets/images/favicons/apple-icon-76x76.png">
    <link rel="apple-touch-icon" sizes="114x114" href="./assets/images/favicons/apple-icon-114x114.png">
    <link rel="apple-touch-icon" sizes="120x120" href="./assets/images/favicons/apple-icon-120x120.png">
    <link rel="apple-touch-icon" sizes="144x144" href="./assets/images/favicons/apple-icon-144x144.png">
    <link rel="apple-touch-icon" sizes="152x152" href="./assets/images/favicons/apple-icon-152x152.png">
    <link rel="apple-touch-icon" sizes="180x180" href="./assets/images/favicons/apple-icon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192"  href="./assets/images/favicons/android-icon-192x192.png">
    <link rel="icon" type="image/png" sizes="32x32" href="./assets/images/favicons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="96x96" href="./assets/images/favicons/favicon-96x96.png">
    <link rel="icon" type="image/png" sizes="16x16" href="./assets/images/favicons/favicon-16x16.png">
    <link rel="manifest" href="./assets/images/favicons/manifest.json">
    <meta name="msapplication-TileColor" content="#FFFFFF">
    <meta name="msapplication-TileImage" content="/ms-icon-144x144.png">
    <meta name="theme-color" content="#FFFFFF"> 
    

    <!-- stylization paths; Css -->    
    <link rel="stylesheet" href="./assets/css/style.css">
</head>

<body>
    <!-- The WebSite Start here -->

    <!-- header -->
    <header class=""></header>
    <!-- end header -->

    <!-- WebSite menu -->
    <nav class=""></nav>
    <!-- end WebSite menu -->

    <!-- WebSite content -->
    <main>
        <form method="post">
            <label for="nome">Nome:</label>
            <input type="text" name="nome" placeholder="Digite seu nomizinho!">
            <br>
            <input type="text" name="idade" placeholder="Digite sua idade">
            <br>
            <button>Enviar</button>
        </form>
    </main>
    <!-- end WebSite content -->

    <!-- Footer -->
    <footer class=""></footer>
    <!-- end Footer -->


    <?php
        echo $_GET['nome']." você tem ".$_GET['idade']." anos";
        
    ?>

    <!-- Bootstrap Files Path in JavaScript -->
    <script src="./assets/js/jquery.js"></script>
    <script src="./assets/js/popper.js"></script>
    <script src="./assets/js/bootstrap.js"></script>

    <!-- link javascript file -->
    <script src="./assets/js/motor.js"></script>
</body>
</html>