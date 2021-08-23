class ArtGallery {

    constructor(creator) {
        this.creator = creator;
        this.possibleArticles = { "picture":200,"photo":50,"item":250 };
        this.listOfArticles = [];
        this.guests = [];
    }

    addArticle(articleModel,articleName,quantity) {

        let checker = articleModel.toLowerCase();

        if(checker != 'picture' && checker != 'photo' && checker != 'item') {

            throw new Error('This article model is not included in this gallery!');


        }


        let currentArticle = this.listOfArticles.find(x=> x.articleName == articleName);

        if(currentArticle == undefined) {

            currentArticle['artiicleModel'] = articleModel;
            currentArticle['articleName'] = articleName;
            currentArticle['quantity'] = Number(quantity);

            this.listOfArticles.push(currentArticle);
            


        } else {

            if(currentArticle['articleModel'] == articleModel) {
                currentArticle['quantity'] += Number(quantity);
            }

        }


         //TODO - STRING not sure is like this
        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;



    }

    inviteGuest (guestName , personality) {


        let currentGuest = this.guests.find(x=>x.guestName==guestName);

        if(currentGuest != undefined) {

            throw new Error(`${guestName} has already been invited.`)

        } else {

            currentGuest['guestName'] = guestName;
            currentGuest['purchaseArticle'] = 0;

            if(personality=='Vip') {
                currentGuest['points'] = 500;
            } else if(personality == 'Middle') {
                currentGuest['points'] = 250;
            } else {
                currentGuest['points'] = 50;
            }

            this.guests.push(currentGuest);

            return `You have successfully invited ${guestName}!`;


        }


    }


    buyArticle(articleModel, articleName, guestName) {


        let currentArticle = this.listOfArticles.find(x=>x.articleName == articleName && x.articleModel == articleModel);

        if(currentArticle == undefined) {
            throw new Error('This article is not found.');
        }

        if(currentArticle.quantity==0){
            return `The ${articleName} is not available.`;
        }

        let currentGuest = this.guests.find(x=>x.guestName == guestName);

        if(currentGuest == undefined) {
            return 'This guest is not invited.';
        }


        if(currentGuest.points >= this.possibleArticles['articleModel']) {

            currentGuest.points -= this.possibleArticles['articleModel'];
            currentArticle.purchaseArticle +=1;
            currentGuest.quantity -=1;

            return `${guestName} successfully purchased the article worth ${thiis.possibleArticles['articleModel']} points.`;



        } else {

            return `You need to more points to purchase the article.`;
        }


    }

    showGalleryInfo(criteria) {

        let info = [];

        if(criteria == 'article') {

            info.push('Articles information:');
            this.listOfArticles.forEach(x=>info.push(`${x.articleModel} - ${x.articleName} - ${x.quantity}`));


            return info.join('\n');


        } else if (criteria == 'guest') {

            info.push('Guests information:');

            this.guests.forEach(x=>info.push(`${x.guestName} - ${x.purchaseArticle}`));




        }

    }


}

const artGallery = new ArtGallery('Curtis Mayfield');
console.log(artGallery.addArticle('picture', 'Mona Liza', 3));
console.log(artGallery.addArticle('Item', 'Ancient vase', 2));
console.log(artGallery.addArticle('PICTURE', 'Mona Liza', 1));
