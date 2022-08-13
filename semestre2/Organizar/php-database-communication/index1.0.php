<?php

include("connection.php");

if (isset($_FILES['arquivo'])) {
    $arquivo = $_FILES['arquivo'];

    if ($arquivo['error'])
        die("Falha ao enviar arquivo");

    if ($arquivo['size'] > 2097152)
        die("arquivo muito grande!! Max: 2MB");

    $pasta = "arquivos/";
    $nomeDoArquivo = $arquivo['name'];
    $novonomeDoArquivo = uniqid();
    $extensao = strtolower(pathinfo($nomeDoArquivo, PATHINFO_EXTENSION));

    if ($extensao <> "jpg" && $extensao <> 'png' && $extensao <> 'jpeg')
        die("Tipo de Arquivo não aceito");

    $path = $pasta . $novonomeDoArquivo . "." . $extensao;

    $deu_certo = move_uploaded_file($arquivo["tmp_name"], $path);
    if ($deu_certo) {
        $mysql->query("INSERT INTO files (original_name	, path) VALUES('$nomeDoArquivo', '$path')") or die($mysql->error);
        echo "<p>Arquivo enviado com sucesso!</p>";
    } else
        echo "<p>Falha ao enviar arquivo</p>";
}

$sql_query = $mysql->query("SELECT * FROM files") or die($mysql->error);

?>
<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>File Upload</title>
</head>

<body>
    <form method="POST" enctype="multipart/form-data" action="">
        <p><label for="">Selecione o arquivo</label>
            <input name="arquivo" type="file">
        </p>
        <button type="submit">Enviar arquivos</button>
    </form>

    <table border="1" cellpadding="10">
        <thead>
            <th>Previw</th>
            <th>Arquivo</th>
            <th>Data de Envio</th>
        </thead>
        <tbody>
            <?php
                while($arquivo = $sql_query->fetch_assoc()) {
            ?>
            <tr>
                <td><img src="<?php echo $arquivo['path']; ?>" width="180px"></td>


                <td><a target="_brak" href="<?php echo $arquivo['path']; ?>"><?php echo $arquivo['original_name']; ?></a></td>


                <td><?php echo date("d/m/Y H:i", strtotime($arquivo['data_upload'])); ?></td>
            </tr>
            <?php
                }
            ?>
        </tbody>
    </table>
                
    
</body>

</html>

<!-- iformations bytes
    1024 bytes == 1kb
    1024 kb == 1mb -->
 