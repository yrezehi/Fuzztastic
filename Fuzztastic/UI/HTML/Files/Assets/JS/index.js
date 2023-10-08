
document.addEventListener("DOMContentLoaded", function () {
	setTimeout(() => {
		(function toggleContent() {
			[
				document.querySelector("div[data-type=\"header-content\"]"),
				document.querySelector("canvas")
			].forEach((element, index) => {
				setTimeout(() => {
					element.style.opacity = "0";
				}, index * 1000);
			});
			setTimeout(() => {
				var mainContentElement = document.querySelector("div[data-type=\"main-content\"]");
				mainContentElement.style.opacity = "1";

				[
					document.querySelector("div[data-type=\"header-content\"]"),
					document.querySelector("canvas")
				].forEach(elementToDestory => {
					elementToDestory.remove();
				});
			}, 2000);
		})();
	}, 1000);
});