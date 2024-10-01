document.addEventListener("DOMContentLoaded", function() {
    const ddlDanhsachhangsx = document.querySelector("#ddlDanhsachhangsx");
    const btnAdd = document.querySelector(".add");
    const btnSave = document.querySelector(".save");
    const btnCancel = document.querySelector(".cancel");
    const lblHang = document.querySelector(".lblHang");
    const txtHang = document.querySelector(".txtHang");

    const Hang = ["Intel", "AMD", "Apple"];

    function render() {
        for (var i = 0; i < Hang.length; i++) {
            const option = document.createElement("option");
            option.text = Hang[i].trim();
            ddlDanhsachhangsx.appendChild(option);
        }
    }
    function onCancel() {
        ddlDanhsachhangsx.innerHTML = "";
        txtHang.value = "";
        render();

        lblHang.classList.remove("active");
        txtHang.classList.remove("active");
        btnSave.classList.remove("active");
        btnAdd.classList.remove("inactive");
    }
    render();

    btnAdd.addEventListener("click", function (e) {
        e.preventDefault();
        lblHang.classList.add("active");
        txtHang.classList.add("active");
        btnSave.classList.add("active");
        btnAdd.classList.add("inactive");
        
    });
    btnSave.addEventListener("click", function (e) {
        e.preventDefault();
        if (txtHang.value.trim() === "") {
            alert("Yêu cầu nhập nội dung");
            txtHang.value = "";
            txtHang.focus();
        } else {
            if (txtHang.value.trim() !== "") {
                if (
                    Hang.map((value) => value.toLowerCase()).indexOf(txtHang.value.trim()) === -1 &&
                    Hang.indexOf(txtHang.value.trim()) === -1
                ) {
                    Hang.push(txtHang.value.trim());
                    onCancel();
                } else {
                    alert("Trùng hãng trong danh sách");
                    txtHang.focus();
                }
            }
        }
    });
    btnCancel.addEventListener("click", function (e) {
        e.preventDefault();
        onCancel();
    });
});