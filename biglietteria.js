function GeneraQr() {
    var cognome = document.getElementById('cognome').value;
    var nome = document.getElementById('nome').value;
    var data = document.getElementById('data').value;
    var sesso = document.getElementById('sesso').value;
    var settore = document.getElementById('settore').value;
    var fila = document.getElementById('fila').value;
    var posto = document.getElementById('posto').value;

    var str = cognome;
    str += ";";
    str += nome;
    str += ";";
    str += data;
    str += ";";
    str += sesso;
    str += ";";
    str += settore
    str += ";";
    str += fila
    str += ";";
    str += posto
    str += ";";


    jQuery('#qrcodeTable').qrcode({
        render: "table",
        text: str
    });
}