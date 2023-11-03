// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//trang thai
$(document).ready(function () {
    "use strict";
    var current_fs, next_fs, previous_fs; //fieldsets
    var opacity;
    var current = 1;
    var c = 0;
    var steps = $("fieldset").length;

    setProgressBar(current);

    $(".progressbar li").on("click", function () {
        $(".progress-bar li active").removeClass("active");
        $(this).addClass("active");
        current_fs = $(this);

        showActive(current_fs.index());
        showFieldset(current_fs.index());
    });

    $(".next").click(function () {
        current_fs = $(this).parent().parent().parent();

        next_fs = $(this).parent().parent().parent().next();
        c = next_fs.index();

        //Add Class Active
        $(".progressbar li").eq($("fieldset").index(next_fs)).addClass("active");

        //show the next fieldset
        next_fs.show();
        next_fs.animate({ scrollTop: 0 } * 100);
        $(".fieldset-card").scrollTop(0);

        //hide the current fieldset with style
        current_fs.animate(
            { opacity: 0 },
            {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                        display: "none",
                        position: "relative",
                    });

                    next_fs.css({ opacity: opacity });
                },
                duration: 500,
            }
        );
        setProgressBar(++current);
    });

    $(".previous").click(function () {
        current_fs = $(this).parent().parent().parent();
        previous_fs = $(this).parent().parent().parent().prev();
        c = previous_fs.index();

        //Remove class active
        $(".progressbar li")
            .eq($("fieldset").index(current_fs))
            .removeClass("active");

        //show the previous fieldset
        previous_fs.show();
        $(".fieldset-card").scrollTop(0);

        //hide the current fieldset with style
        current_fs.animate(
            { opacity: 0 },
            {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                        display: "none",
                        position: "relative",
                    });
                    previous_fs.css({ opacity: opacity });
                },
                duration: 500,
            }
        );
        setProgressBar(--current);
    });

    function setProgressBar(curStep) {
        var percent = parseFloat(100 / steps) * curStep;
        percent = percent.toFixed();
        $(".progress-bar").css("width", percent + "%");
    }

    function showActive(index) {
        for (let i = 0; i < 5; i++) {
            if (i <= index) {
                $(".progressbar li").eq(i).addClass("active");
            } else {
                $(".progressbar li").eq(i).removeClass("active");
            }
        }
    }
    function showFieldset(index) {
        //show the next fieldset
        if (c != index) {
            $("fieldset").eq(index).show();
            $(".fieldset-card").scrollTop(0);
            //hide the current fieldset with style
            $("fieldset").eq(c).css({
                display: "none",
                position: "relative",
            });
            $("fieldset").eq(index).css({ opacity: 1 });
        }

        c = index;
    }
});


var tabLinks = document.querySelectorAll(".tablinks");
var tabContent = document.querySelectorAll(".tabcontent");

tabLinks.forEach(function (el) {
    el.addEventListener("click", openTabs);
});


function openTabs(el) {
    var btn = el.currentTarget; // lắng nghe sự kiện và hiển thị các element
    var electronic = btn.dataset.electronic; // lấy giá trị trong data-electronic

    tabContent.forEach(function (el) {
        el.classList.remove("active");
    }); //lặp qua các tab content để remove class active

    tabLinks.forEach(function (el) {
        el.classList.remove("active");
    }); //lặp qua các tab links để remove class active

    document.querySelector("#" + electronic).classList.add("active");
    // trả về phần tử đầu tiên có id="" được add class active

    btn.classList.add("active");
    // các button mà chúng ta click vào sẽ được add class active
}