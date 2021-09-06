function GeneraQr() {
    var str = document.getElementById('cognome').value;
    str += document.getElementById('nome').value;
    str += document.getElementById('data').value;
    str += document.getElementById('sesso').value;
    str += document.getElementById('settore').value;
    str += document.getElementById('fila').value;
    str += document.getElementById('posto').value;


    jQuery('#qrcodeTable').qrcode({
        render: "table",
        text: str
    });
}