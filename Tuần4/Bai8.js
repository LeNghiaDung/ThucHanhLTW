const btnAdd = document.querySelector("#btnAdd");
const btnCancel = document.querySelector("#btnCancel");
const txtTenVXL = document.querySelector("#txtTenVXL");
const txtHang = document.querySelector("#txtHang");
const txtNgayramat = document.querySelector("#txtNgayramat");
const txtGia = document.querySelector("#txtGia");
const tbody = document.querySelector("tbody");
const tr = document.querySelector("tr");
const td = document.querySelector("td");

const data = [];

function VXL(fullname, brand, date, price) {
  this.fullname = fullname;
  this.brand = brand;
  this.date = date;
  this.price = price;
}

txtNgayramat.addEventListener("change", function () {
    var date = new Date();
    var day = Number(date.getDate());
    var month = Number(date.getMonth()) + 1;
    var year = Number(date.getFullYear());

    var datePicked = txtNgayramat.value.split("-");
    function disableAddButton() {
        btnAdd.disabled = true;
    }

    if(Number(datePicked[0]) > year){
        alert("Ngày ra mắt không được lớn hơn ngày hiện tại");
        txtNgayramat.value = "";
        txtNgayramat.focus();
        disableAddButton();  
    }
    else if(Number(datePicked[1]) > month){
            alert("Ngày ra mắt không được lớn hơn ngày hiện tại");
            txtNgayramat.value = "";
            txtNgayramat.focus();
            disableAddButton();
    }
    else if (Number(datePicked[3]) > day){
            alert("Ngày ra mắt không được lớn hơn ngày hiện tại");
            txtNgayramat.value = "";
            txtNgayramat.focus();
            disableAddButton();
    }
    else{
        btnAdd.disabled = false;
    }
});

function render() {
    for (var i = 0; i< data.length; i++){
        var trElement = document.createElement("tr");
        var tdSTT = trElement.appendChild(document.createElement("td")).classList.add("count");
        var tdTen = trElement.appendChild(document.createElement("td"));
        var tdHang = trElement.appendChild(document.createElement("td"));
        var tdNgayramat = trElement.appendChild(document.createElement("td"));
        var tdGia = trElement.appendChild(document.createElement("td"));

        tdTen.innerHTML = data[i].fullname;
        tdHang.innerHTML = data[i].brand;
        tdNgayramat.innerHTML = new Date(data[i].date).toLocaleDateString("vi-VN",{
            day: "2-digit",
            month: "2-digit",
            year: "numeric"
        });
        
        tdGia.innerHTML = new Intl.NumberFormat("vi-VN", {
            style: "currency",
            currency: "VND",
        }).format(data[i].price);

        tbody.appendChild(trElement)
    }
}

function pushData(TenVL,HangVL,NgayVL,GiaVL){
    data.push(new VXL(TenVL,HangVL,NgayVL,GiaVL));
    render();
}

pushData("VXL1","Hang1","2021-09-01",1000000);
pushData("VXL2","Hang2","2021-09-02",2000000);
render();

function getData(){
    const TenVL = txtTenVXL.value.trim();
    const HangVL = txtHang.value.trim();
    const NgayVL = txtNgayramat.value.trim();
    const GiaVL = txtGia.value.trim();

    if(TenVL !== "" && HangVL !== "" && NgayVL !== "" && GiaVL !== ""){
        if(isNaN(GiaVL) || GiaVL < 0){
            alert("Giá trị nhập vào không hợp lệ");
            txtGia.value = "";
            txtGia.focus();
        }
        else{
            var check = false;
            data.forEach(function(item){
                if(item.fullname === TenVL){
                    check = true; 
                    alert("Tên đã tồn tại");
                    txtTenVXL.focus;
                }
            },this);
            if(check === false){
                pushData(TenVL,HangVL,NgayVL,GiaVL);
                console.log(data);
            }
        }
    }
    else
    {
        alert("Nhập thiếu thông tin");
    }
}
btnAdd.addEventListener("click", function(e){
    e.preventDefault();
    getData();
    tbody.innerHTML = "";
    render();
});

btnCancel.addEventListener("click", function(e){
    e.preventDefault();
    txtTenVXL.value = "";
    txtHang.value = "";
    txtNgayramat.value = "";
    txtGia.value = "";
});
