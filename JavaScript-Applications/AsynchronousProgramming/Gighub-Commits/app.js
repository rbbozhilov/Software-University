function loadCommits() {
    
    let ulElement = document.getElementById('commits');
    let username = document.getElementById('username');
    let repo = document.getElementById('repo');
    let url = `https://api.github.com/repos/${username.value}/${repo.value}/commits`;

    fetch(url)
      .then((response) => {

        if(!response.ok) {
            let liElement = document.createElement('li');
            liElement.textContent = `Error: ${response.status} (Not Found)`
            ulElement.appendChild(liElement);
            throw new Error();
        }


          return response.json();
      })
      .then((dataFromResponse) => {

        dataFromResponse.forEach(currentData => {

            let liElement = document.createElement('li');
            liElement.textContent = `${currentData.commit.author.name}: ${currentData.commit.message}`;
            ulElement.appendChild(liElement);
        });


      })
      .catch((error) => {



      }) 




}
