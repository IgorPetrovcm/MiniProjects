function redirectToCreateRow()
{
    window.location.href = "/Home/CreateRow";
}

let btn_createRow = document.getElementById('btn_createRow');
btn_createRow.addEventListener('click',redirectToCreateRow);