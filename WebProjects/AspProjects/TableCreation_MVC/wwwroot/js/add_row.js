document.getElementById('btn_addRow').addEventListener('click',add_row1);

function add_row1(e)
{
    const count_column = document.getElementById('count_column');
    if (count_column.innerText == null){
        logError_NullReference();
        e.preventDefault();
    }
}
function logError_NullReference(){
    let box = document.getElementById('input_box');
    let error_text = document.createElement('small');

    error_text.innerText = 'Input count column, please';
    error_text.class = 'form-text text-muted';
    
    box.appendChild(error_text);

}