During the development of the InventoryHub project, several improvements were made to ensure smooth integration between the Blazor WebAssembly front-end and the Minimal API back-end.

In the front-end, a dedicated service class was created to centralize and manage all API requests related to product data. This helped reduce redundant API calls and improved maintainability by abstracting the fetching logic out of the component. Client-side caching was also introduced to prevent repeated requests for the same data during a session, which improved performance and responsiveness.

On the back-end, structured JSON responses were implemented using strong models that matched the expected structure on the client. A shared class library was introduced to contain models such as Product and Category, which ensured consistency between both ends of the application and reduced duplication.

Caching strategies were applied on the server side using in-memory caching. This minimized unnecessary processing and response generation, especially for endpoints that serve static or infrequently changing data.

Throughout the development process, common issues were encountered, such as type mismatches, incorrect deserialization, CORS restrictions, and duplicate logic. These were addressed by organizing code into clearly separated layers, using proper error handling, and applying standard web development practices like dependency injection and content-type enforcement.

Through this experience, a deeper understanding of structuring full-stack applications was gained—particularly in maintaining consistency between client and server, optimizing performance with caching, and improving the clarity and modularity of the codebase.