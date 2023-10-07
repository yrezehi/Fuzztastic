
document.addEventListener("DOMContentLoaded", function() {
	function toggleContent(){
		[
			document.querySelector("div[data-type=\"header-content\"]"),
			document.querySelector("canvas")
		].forEach((element, index) => {
			setTimeout(() => {
				element.style.opacity = "0";
			}, index * 1000);
		});
	}
});