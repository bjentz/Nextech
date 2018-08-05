import { HackernewsModule } from './hackernews.module';

describe('HackernewsModule', () => {
  let hackernewsModule: HackernewsModule;

  beforeEach(() => {
    hackernewsModule = new HackernewsModule();
  });

  it('should create an instance', () => {
    expect(hackernewsModule).toBeTruthy();
  });
});
