<?php
include("connection.php");
$sql_query = $mysql->query("SELECT * FROM files") or die($mysql->error);

if (isset($_GET['deletar'])) {

    $id = intval($_GET['deletar']);
    $sql_query = $mysql->query("SELECT * FROM files WHERE id = '$id' ") or die($mysql->error);
    $arquivo = $sql_query->fetch_assoc();

    if(unlink($arquivo['path'])) {
        $deu_certo = $mysql->query("DELETE FROM files WHERE id = '$id' ") or die($mysql->error);
        if($deu_certo)
            echo "<p>Arquivo Deletado</p>";
    }


}

function enviarArquivo($error, $size, $name, $tap_name)
{
    include("connection.php");

    if ($error)
        die("Falha ao enviar arquivo");

    if ($size > 5242880)
        die("Arquivo muito grande!! Max: 5MB");

    $pasta = "arquivos/";
    $nomeDoArquivo = $name;
    $novonomeDoArquivo = uniqid();
    $extensao = strtolower(pathinfo($nomeDoArquivo, PATHINFO_EXTENSION));

    if ($extensao <> "jpg" && $extensao <> 'png' && $extensao <> 'jpeg')
        die("Tipo de Arquivo não aceito");

    $path = $pasta . $novonomeDoArquivo . "." . $extensao;

    $deu_certo = move_uploaded_file($tap_name, $path);
    if ($deu_certo) {
        $mysql->query("INSERT INTO files (original_name	, path) VALUES('$nomeDoArquivo', '$path')") or die($mysql->error);
        return true;
    } else
        return false;
}

if (isset($_FILES['arquivo'])) {
    $arquivos = $_FILES['arquivo'];
    $tudo_certo = true;
    foreach ($arquivos['name'] as $index => $arq) {
        $deu_certo = enviarArquivo($arquivos['error'][$index], $arquivos['size'][$index], $arquivos['name'][$index], $arquivos["tmp_name"][$index]);
        if (!$deu_certo)
            $tudo_certo = false;
    }

    if ($tudo_certo)
        echo "<p>Todos os arquivos foram enviados com sucesso!</p>";
    else
        echo "<p>Falha ao enviar um ou mais arquivos!</p>";
}



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
    <form method="POST" enctype="multipart/form-data">
        <p><label for="">Selecione o arquivo</label>
            <input multiple name="arquivo[]" type="file">
        </p>
        <button type="submit">Enviar arquivos</button>
    </form>

    <table border="1" cellpadding="10">
        <thead>
            <th>Previw</th>
            <th>Arquivo</th>
            <th>Data de Envio</th>
            <th><a href="index.php">Atualizar</a></th>
        </thead>
        <tbody>
            <?php
                while($arquivo = $sql_query->fetch_assoc()) {
            ?>
            <tr>
                <td><img src="<?php echo $arquivo['path']; ?>" width="180px"></td>


                <td><a target="_brak" href="<?php echo $arquivo['path']; ?>"><?php echo $arquivo['original_name']; ?></a></td>


                <td><?php echo date("d/m/Y H:i", strtotime($arquivo['data_upload'])); ?></td>

                <td><a href="index.php?deletar=<?php echo $arquivo['id']; ?>">Deletar</a></td>
            </tr>
            <?php
                }
            ?>
        </tbody>
    </table>
    </table>


</body>

</html>

<!-- iformations bytes
    1024 bytes == 1kb
    1024 kb == 1mb -->