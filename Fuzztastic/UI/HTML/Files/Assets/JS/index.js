
document.addEventListener("DOMContentLoaded", function() {
	var landingContentElements = [
		document.querySelector("div[data-type=\"header-content\"]"),
		document.querySelector("canvas")
	];

	function toggleContent(){
		landingContentElements.forEach((element, index) => {
			setTimeout(() => {
				element.style.opacity = "0";
			}, index * 1000);  // one sec interval
		});
	}
});