async function loadRepos() {
	let currentUsername = document.getElementById('username').value;
	let baseURL = `https://api.github.com/users/${currentUsername}/repos`;

	try {

	
	let responseURL = await fetch(baseURL);

	if(!responseURL.ok) {
		throw new Error(`${responseURL.status} is not ok`);
	}

	let dataURL = await responseURL.json();

	let ulElement = document.getElementById('repos');
	ulElement.innerHTML = '';

	dataURL.forEach(element => {
		
		let liElement = document.createElement('li');
		liElement.textContent = element.full_name;
		ulElement.appendChild(liElement);

	});

	} catch(error) {

		console.log(error);
	}

}
