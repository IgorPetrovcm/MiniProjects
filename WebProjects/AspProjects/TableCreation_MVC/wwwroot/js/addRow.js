var btn_add = document.getElementById('btn_addRow');

var input_countColumn = document.getElementById('countColumn');

var smallMessage = document.getElementById('smallMessage');

input_countColumn.onchange = function ()
{
    btn_add.disabled = true;
    if (isNaN(this.value)) {
        smallMessage.innerText = 'Input value must by a number';
        return;
    }   
    if (Number(this.value) > 10 || Number(this.value) < 1)
    {
        smallMessage.innerText = 'Input value > 0 and < 11';
        return;
    }
    btn_add.disabled=false;
    smallMessage.innerText = 'Ok';
}