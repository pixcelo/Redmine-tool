import fetch from 'node-fetch';

export class Fetcher {
    async fetchUrl(url: string) {
        try {
            const res = await fetch(url);
            if (!res.ok) {
                throw new Error(`${res.status} ${res.statusText}`);
            }
            const text = await res.text();
            console.log(text);
        } catch (err) {
            console.error(err);
        }
    }
}
