$(document).ready(function () {
    let passwordInput = document.querySelector(".password-input");

    passwordInput.addEventListener("input", function () {
        if (this.value != "") {
            $(".fa-eye").removeClass("d-none")
        }
        else {
            $(".fa-eye").addClass("d-none")
            $(".fa-eye-slash").addClass("d-none")
            this.setAttribute("type", "password");
        }
    })

    let showBtn = document.querySelector(".form .fa-eye");
    let hideBtn = document.querySelector(".form .fa-eye-slash");

    showBtn.addEventListener("click", function () {
        this.classList.add("d-none");
        $(".fa-eye-slash").removeClass("d-none");
        this.parentElement.firstElementChild.setAttribute("type", "text");
    })

    hideBtn.addEventListener("click", function () {

        this.classList.add("d-none");
        $(".fa-eye").removeClass("d-none");
        this.parentElement.firstElementChild.setAttribute("type", "password");
    })
});